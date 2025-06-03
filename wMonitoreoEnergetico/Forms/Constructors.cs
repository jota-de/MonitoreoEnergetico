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
    public partial class frmConstructors : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        
        public frmConstructors()
        {
            InitializeComponent();
        }

        private void frmConstructors_Load(object sender, EventArgs e)
        {
            btnConstructors.Enabled = false; // Inhabilitar botón al cargar el formulario
            #region[combo Especializacion constructor]
            cmbEspecialization.Items.Add("--");
            cmbEspecialization.Items.Add("Solar");
            cmbEspecialization.Items.Add("Wind");
            cmbEspecialization.Items.Add("Hydro");
            cmbEspecialization.SelectedIndex = 0;
            #endregion
        }

       
             private bool ValidarCampos()
             {
                if (string.IsNullOrEmpty(txtConstructorName.Text) ||
                    cmbEspecialization.SelectedIndex == 0 ||
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
            cmbEspecialization.SelectedIndex = 0;
            txtCountryConstructor.Clear();
            txtEmailConstructor.Clear();
            txtPhoneConstructor.Clear();
        }
        private void btnCreateConstructor_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                var constructor = new Constructor
                {
                    nombreConstructor = txtConstructorName.Text,
                    paisOrigenConstructor = txtCountryConstructor.Text,
                    tipoConstructor = cmbEspecialization.SelectedItem.ToString(),
                    emailConstructor = txtEmailConstructor.Text,
                    telefonoConstructor = Convert.ToInt32(txtPhoneConstructor.Text.Trim())
                };
                _uow.constructorRepository.Insertar(constructor);
                LimpiarCampos();
                MessageBox.Show("Constructor creado correctamente.");

            }
        }

        private void btnViewConstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmViewConstructors().Show();
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

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
