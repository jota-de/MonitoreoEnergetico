using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Data.Repositories;
using wMonitoreoEnergetico.Data.UnitOfWork;

namespace wMonitoreoEnergetico.Forms
{
    public partial class frmViewConstructors : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private short? ConstructorSeleccionadoId = null;
        public frmViewConstructors()
        {
            InitializeComponent();
        }

        private void frmViewConstructors_Load(object sender, EventArgs e)
        {
            btnConstructors.Enabled = false; // Inhabilitar botón al cargar el formulario
            #region[combo Especializacion constructor]
            cmbTypeConstructor.Items.Add("--");
            cmbTypeConstructor.Items.Add("Solar");
            cmbTypeConstructor.Items.Add("Wind");
            cmbTypeConstructor.Items.Add("Hydro");
            cmbTypeConstructor.SelectedIndex = 0;
            #endregion
        }
        private void CargarConstructor()
        {
            dgvConstructor.DataSource = _uow.constructorRepository.ObtenerTodos();
            dgvConstructor.ClearSelection();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtConstructorName.Text) ||
                cmbTypeConstructor.SelectedIndex == 0 ||
                string.IsNullOrEmpty(txtCountryConstructor.Text) ||
                string.IsNullOrEmpty(txtEmailConstructor.Text) ||
                string.IsNullOrEmpty(txtPhoneConstructor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtConstructorName.Clear();
            cmbTypeConstructor.SelectedIndex = 0;
            txtCountryConstructor.Clear();
            txtEmailConstructor.Clear();
            txtPhoneConstructor.Clear();
        }

        private void btnUpdateConstructor_Click(object sender, EventArgs e)
        {
            ConstructorSeleccionadoId = Convert.ToInt16(txtConstructorId.Text.Trim());
            if(ConstructorSeleccionadoId.HasValue && ValidarCampos())
            {
                var Constructor = new Constructor
                {
                    idConstructor = ConstructorSeleccionadoId.Value,
                    nombreConstructor = txtConstructorName.Text,
                    paisOrigenConstructor = txtCountryConstructor.Text,
                    tipoConstructor = cmbTypeConstructor.SelectedItem.ToString(),
                    emailConstructor = txtEmailConstructor.Text,
                    telefonoConstructor = Convert.ToInt32(txtPhoneConstructor.Text.Trim())

                };
                _uow.constructorRepository.Actualizar(Constructor);
                CargarConstructor();
                LimpiarCampos();
            }
        }


        private void btnDeleteConstructor_Click(object sender, EventArgs e)
        {
            if (ConstructorSeleccionadoId.HasValue)
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este Constructor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.constructorRepository.Eliminar(ConstructorSeleccionadoId.Value);
                    CargarConstructor();
                    LimpiarCampos();

                }
            }
        }

        private void btnSearchConstructor_Click(object sender, EventArgs e)
        {
            if (ConstructorSeleccionadoId.HasValue)
            {
                
              _uow.constructorRepository.ObtenerPorId(ConstructorSeleccionadoId.Value);
              CargarConstructor();
              LimpiarCampos();

           
            }
        }
        private void btnBackConstructor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmConstructors().Show();
        }
    }
}
