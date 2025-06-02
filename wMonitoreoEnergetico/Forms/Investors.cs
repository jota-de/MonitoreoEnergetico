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
    public partial class frmInvestors : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        
        public frmInvestors()
        {
            InitializeComponent();
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {

        }

        private void frmInvestors_Load(object sender, EventArgs e)
        {
            //INABILITAR BOTON ESTANDO DENTRO DE SU ENTORNO
            btnInvestor.Enabled = false;

            #region[combo tipoInversor]
            cmbTypeInvestor.Items.Add("--");
            cmbTypeInvestor.Items.Add("Publico");
            cmbTypeInvestor.Items.Add("Privado");
            cmbTypeInvestor.SelectedIndex = 0;
            #endregion                      
        }

        private void btnCreateInvestor_Click(object sender, EventArgs e)
        {
           if(ValidarCampos())
           {
                var inversor = new Investor
                {
                    nombreInversor = txtInvestorName.Text.Trim(),
                    paisOrigenInversor = txtCountryInvestor.Text.Trim(),
                    emailInversor = txtEmailInvestor.Text.Trim(),
                    telefonoInversor = Convert.ToInt32(txtPhoneInvestor.Text.Trim()),
                    tipoInversor = cmbTypeInvestor.SelectedItem.ToString(),
                };

                _uow.InvestorRepository.Insertar(inversor);
                LimpiarCampos();
                MessageBox.Show("Inversor creado correctamente.");

            }
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

        private void btnViewInvestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmViewInvestors().Show();
        }
    }
}
