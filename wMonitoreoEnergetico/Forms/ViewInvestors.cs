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
    public partial class frmViewInvestors : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private short? InversorSeleccionadoId = null;

        public frmViewInvestors()
        {
            InitializeComponent();
        }

        private void ViewInvestors_Load(object sender, EventArgs e)
        {
            //INABILITAR BOTON ESTANDO DENTRO DE SU ENTORNO
            btnInvestor.Enabled = false;

            #region[combo tipoInversor]
            cmbTypeInvestor.Items.Add("--");
            cmbTypeInvestor.Items.Add("Publico");
            cmbTypeInvestor.Items.Add("Privado");
            cmbTypeInvestor.SelectedIndex = 0;
            #endregion       
        
            CargarInversores();
        }
        private void CargarInversores()
        {
            var inversores = _uow.InvestorRepository.ObtenerTodos();
            dgvInvestors.DataSource = inversores;
            dgvInvestors.Columns["Id"].Visible = false; // Ocultar columna Id
            dgvInvestors.ClearSelection(); // Limpiar selección al cargar
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtInvestorName.Text) ||
                cmbTypeInvestor.SelectedIndex == 0 ||
                string.IsNullOrEmpty(txtCountryInvestor.Text) ||
                string.IsNullOrEmpty(txtEmailInvestor.Text) ||
                string.IsNullOrEmpty(txtPhoneInvestor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtInvestorName.Clear();
            cmbTypeInvestor.SelectedIndex = 0;
            txtCountryInvestor.Clear();
            txtEmailInvestor.Clear();
            txtPhoneInvestor.Clear();
        }
        private void btnUpdateInvestor_Click(object sender, EventArgs e)
        {
            if(InversorSeleccionadoId.HasValue && ValidarCampos())
            {
                var inversor = new Investor
                {
                    idInversor = InversorSeleccionadoId.Value,
                    nombreInversor = txtInvestorName.Text.Trim(),
                    tipoInversor = cmbTypeInvestor.SelectedItem.ToString(),
                    paisOrigenInversor = txtCountryInvestor.Text.Trim(),
                    emailInversor = txtEmailInvestor.Text.Trim(),
                    telefonoInversor = Convert.ToInt32(txtPhoneInvestor.Text.Trim())


                };
                _uow.InvestorRepository.Actualizar(inversor);
                CargarInversores();
                LimpiarCampos();
                MessageBox.Show("Inversor actualizado correctamente.");
            }
            else
            {
                MessageBox.Show("Seleccione un inversor para actualizar.");
            }
        }

        private void btnDeleteInvestor_Click(object sender, EventArgs e)
        {
            if(InversorSeleccionadoId.HasValue)
            {
                var confirmResult = MessageBox.Show("¿Está seguro de que desea eliminar este inversor?", "Confirmación", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    _uow.InvestorRepository.Eliminar(InversorSeleccionadoId.Value);
                    CargarInversores();
                    LimpiarCampos();
                    MessageBox.Show("Inversor eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un inversor para eliminar.");
            }
        }

        private void btnClearInvestors_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnBackInvestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInvestors().Show();
        }
    }
}
