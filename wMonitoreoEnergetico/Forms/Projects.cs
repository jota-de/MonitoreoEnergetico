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
using wMonitoreoEnergetico.Data.UnitOfWork;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Forms
{
    public partial class frmProjects : KryptonForm

    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        public frmProjects()
        {
            InitializeComponent();
        }

        private void frmProjects_Load(object sender, EventArgs e)
        {
            //INABILITAR BOTON ESTANDO DENTRO DE SU ENTORNO
            btnProjects.Enabled = false;

            #region[combo tipoInversor]
            cmbTypeEnergy.Items.Add("--");
            cmbTypeEnergy.Items.Add("Solar"); 
            cmbTypeEnergy.Items.Add("Wind");
            cmbTypeEnergy.Items.Add("Hydro");
            cmbTypeEnergy.SelectedIndex = 0;
            #endregion        
           
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtProjectName.Text) ||
                cmbTypeEnergy.SelectedIndex == 0 ||
                string.IsNullOrEmpty(txtProvince.Text) ||
                string.IsNullOrEmpty(txtMunicipality.Text) ||
                string.IsNullOrEmpty(txtUnits.Text) ||
                string.IsNullOrEmpty(txtPower.Text) ||
                string.IsNullOrEmpty(txtIdInvestor.Text)||
                string.IsNullOrEmpty(txtIdConstructor.Text))

            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        private bool VerficarIds()
        {
            if (!short.TryParse(txtIdInvestor.Text.Trim(), out short idInversor))
            {
                MessageBox.Show("ID de inversor no válido.");
                return false;
            }
            var inversores = _uow.InvestorRepository.ObtenerTodos();
            if (!inversores.Any(i => i.idInversor == idInversor))
            {
                MessageBox.Show("El ID de inversor no existe.");
                return false;
            }

            // Validar que el ID del constructor exista
            if (!short.TryParse(txtIdConstructor.Text.Trim(), out short idConstructor))
            {
                MessageBox.Show("ID de constructor no válido.");
                return false;
            }
            var constructores = _uow.constructorRepository.ObtenerTodos();
            if (!constructores.Any(c => c.idConstructor == idConstructor))
            {
                MessageBox.Show("El ID de constructor no existe.");
                return false;
            }

            return true;
        }
        private void LimpiarCampos()
        {
            txtProjectName.Clear();
            cmbTypeEnergy.SelectedIndex = 0;
            txtProvince.Clear();
            txtMunicipality.Clear();
            txtUnits.Clear();
            txtPower.Clear();
            txtIdInvestor.Clear();
            txtIdConstructor.Clear();
        }

        private void btnCreateProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos() && VerficarIds())
                {
                    var proyecto = new Project
                    {
                        nombreProyecto = txtProjectName.Text,
                        tipoGeneracion = cmbTypeEnergy.SelectedItem.ToString(),
                        departamento = txtProvince.Text,
                        municipio = txtMunicipality.Text,
                        numeroUnidades = Convert.ToInt16(txtUnits.Text.Trim()),
                        capacidadInstalada = Convert.ToInt32(txtPower.Text.Trim()),
                        idInversor = Convert.ToInt16(txtIdInvestor.Text.Trim()),
                        idEmpresa = Convert.ToInt16(txtIdConstructor.Text.Trim())
                    };
                    _uow.ProjectRepository.Insertar(proyecto);
                    LimpiarCampos();
                    MessageBox.Show("Proyecto creado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al crear el proyecto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmViewProject().Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void btnInvestor_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmInvestors().Show();
        }

        private void btnConstructors_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmConstructors().Show();
        }
    }
}
