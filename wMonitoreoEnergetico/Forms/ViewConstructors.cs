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

            CargarConstructor();
        }
        private void CargarConstructor()
        {
            var constructores = _uow.constructorRepository.ObtenerTodos();
            dgvConstructor.DataSource =constructores;
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
            else
            {
                MessageBox.Show("Seleccione un Constructor para actualizar.");
            }

        }


        private void btnDeleteConstructor_Click(object sender, EventArgs e)
        {
            ConstructorSeleccionadoId = Convert.ToInt16(txtConstructorId.Text.Trim());
            if (ConstructorSeleccionadoId.HasValue)
            {
                var confirm = MessageBox.Show("¿Estás seguro de eliminar este Constructor?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    _uow.constructorRepository.Eliminar(ConstructorSeleccionadoId.Value);
                    CargarConstructor();
                    LimpiarCampos();
                    MessageBox.Show("Constructor eliminado correctamente.");

                }
            }
            else
            {
                MessageBox.Show("Seleccione un Constructor para eliminar.");
            }
        }

        private void btnSearchConstructor_Click(object sender, EventArgs e)
        {
           
            BuscarYMostrarConstructorPorId(Convert.ToInt16(txtConstructorId.Text.Trim()));
        }
        private void BuscarYMostrarConstructorPorId(short idConstructor)
        {
            var constructores = _uow.constructorRepository.ObtenerTodos();
            var construtor = constructores.FirstOrDefault(i => i.idConstructor == idConstructor);

            if (construtor != null)
            {
                ConstructorSeleccionadoId = construtor.idConstructor;
                txtConstructorName.Text = construtor.nombreConstructor;
                cmbTypeConstructor.SelectedItem = construtor.tipoConstructor;
                txtCountryConstructor.Text = construtor.paisOrigenConstructor;
                txtEmailConstructor.Text = construtor.emailConstructor;
                txtPhoneConstructor.Text = construtor.telefonoConstructor.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un inversor con ese ID.");
                LimpiarCampos();
            }
        }
        private void btnBackConstructor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmConstructors().Show();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProjects().Show();
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInvestors().Show();
        }
    }
}
