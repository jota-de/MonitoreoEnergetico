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
using wMonitoreoEnergetico.Services;
using SistemaGestionProductosMVC.Utils;

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
            InversorSeleccionadoId = Convert.ToInt16(txtInvestorId.Text.Trim());
            if (InversorSeleccionadoId.HasValue && ValidarCampos())
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
            var auth = new AuthService();

            var usuario = auth.CheckRol(SesionUsuario.Actual,SesionUsuario.Actual.Rol);
            if (usuario)
            {
                InversorSeleccionadoId = Convert.ToInt16(txtInvestorId.Text.Trim());
                if (InversorSeleccionadoId.HasValue)
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
            else
            {
                MessageBox.Show("No tienes permisos para acceder al panel de control.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnBackInvestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInvestors().Show();
        }
        private void btnSearchInvestor_Click(object sender, EventArgs e)
        {
            BuscarYMostrarInversorPorId(Convert.ToInt16(txtInvestorId.Text.Trim()));
        }
        private void BuscarYMostrarInversorPorId(short idInversor)
        {
            var inversores = _uow.InvestorRepository.ObtenerTodos();
            var inversor = inversores.FirstOrDefault(i => i.idInversor == idInversor);

            if (inversor != null)
            {
                InversorSeleccionadoId = inversor.idInversor;
                txtInvestorName.Text = inversor.nombreInversor;
                cmbTypeInvestor.SelectedItem = inversor.tipoInversor;
                txtCountryInvestor.Text = inversor.paisOrigenInversor;
                txtEmailInvestor.Text = inversor.emailInversor;
                txtPhoneInvestor.Text = inversor.telefonoInversor.ToString();
            }
            else
            {
                MessageBox.Show("No se encontró un inversor con ese ID.");
                LimpiarCampos();
            }
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProjects().Show();
        }
        private void btnConstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmConstructors().Show();
        }
        //---------------- OMITIR LO SIGUIENTE-------------------------
        private void btnClearInvestors_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
