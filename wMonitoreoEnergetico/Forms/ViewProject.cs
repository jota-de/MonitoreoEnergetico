using ComponentFactory.Krypton.Toolkit;
using SistemaGestionProductosMVC.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wMonitoreoEnergetico.Data.Repositories;
using wMonitoreoEnergetico.Data.UnitOfWork;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Services;

namespace wMonitoreoEnergetico.Forms
{
    
    public partial class frmViewProject : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private short? ProjectSeleccionadoID = null;

        public frmViewProject()
        {
            InitializeComponent();
        }

        private void ViewProject_Load(object sender, EventArgs e)
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
            CargarProjects();
        }
        private void CargarProjects()
        {
            var projects = _uow.ProjectRepository.ObtenerTodos();
            dvgProject.DataSource = projects;
            dvgProject.ClearSelection();
        }
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtProjectName.Text) ||
                cmbTypeEnergy.SelectedIndex == 0 ||
                string.IsNullOrEmpty(txtProvince.Text) ||
                string.IsNullOrEmpty(txtMunicipality.Text) ||
                string.IsNullOrEmpty(txtUnits.Text) ||
                string.IsNullOrEmpty(txtPower.Text) ||
                string.IsNullOrEmpty(txtIdInvestor.Text) ||
                string.IsNullOrEmpty(txtIdConstructor.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }
            return true;
        }
        private void LimpiarCampos()
        {
            txtIdProject.Clear();
            txtProjectName.Clear();
            cmbTypeEnergy.SelectedIndex = 0;
            txtProvince.Clear();
            txtMunicipality.Clear();
            txtUnits.Clear();
            txtPower.Clear();
            txtIdInvestor.Clear();
            txtIdConstructor.Clear();
        }

        private void btnUpdateProject_Click(object sender, EventArgs e)
        {
            ProjectSeleccionadoID = Convert.ToInt16(txtIdProject.Text.Trim());
            if(ProjectSeleccionadoID.HasValue && ValidarCampos())
            {
                var Proyecto = new Project
                {
                     idProyecto= ProjectSeleccionadoID.Value,
                     nombreProyecto = txtProjectName.Text,
                     tipoGeneracion = cmbTypeEnergy.SelectedItem.ToString(),
                     numeroUnidades = Convert.ToInt16(txtUnits.Text.Trim()),
                     departamento = txtProvince.Text,
                     municipio = txtMunicipality.Text,
                     capacidadInstalada = Convert.ToInt32(txtPower.Text.Trim()),
                     idInversor = Convert.ToInt16(txtIdInvestor.Text.Trim()),
                     idEmpresa = Convert.ToInt16(txtIdConstructor.Text.Trim())

                };
                _uow.ProjectRepository.Actualizar(Proyecto);
                CargarProjects();
                LimpiarCampos();
            }

            else
            {
                MessageBox.Show("Seleccione un Proyecto para actualizar.");
            }
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            var usuario = auth.CheckRol(SesionUsuario.Actual, SesionUsuario.Actual.Rol);
            if (usuario)
            {
                ProjectSeleccionadoID = Convert.ToInt16(txtIdProject.Text.Trim());
                if (ProjectSeleccionadoID.HasValue)
                {
                    var confirm = MessageBox.Show("¿Estás seguro de eliminar este Proyecto?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        _uow.ProjectRepository.Eliminar(ProjectSeleccionadoID.Value);
                        CargarProjects();
                        LimpiarCampos();
                        MessageBox.Show("Proyecto eliminado correctamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un Proyecto para eliminar.");
                }
            }
            else
            {
                MessageBox.Show("No tienes permisos para acceder al panel de control.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            

        }

        private void btnSearchProject_Click(object sender, EventArgs e)
        {
            BuscarYMostrarProjectPorId(Convert.ToInt16(txtIdProject.Text.Trim()));
        }
        private void BuscarYMostrarProjectPorId(short idProject)
        {
            var Projects = _uow.ProjectRepository.ObtenerTodos();
            var Project = Projects.FirstOrDefault(i => i.idProyecto == idProject);

            if (Project != null)
            {

                ProjectSeleccionadoID = Project.idProyecto;
                txtProjectName.Text = Project.nombreProyecto;
                cmbTypeEnergy.SelectedItem = Project.tipoGeneracion;
                txtProvince.Text = Project.departamento;
                txtMunicipality.Text = Project.municipio;
                txtUnits.Text= Project.numeroUnidades.ToString();
                txtPower.Text= Project.capacidadInstalada.ToString();
                txtIdInvestor.Text= Project.idInversor.ToString();
                txtIdConstructor.Text= Project.idEmpresa.ToString();
               
            }
            else
            {
                MessageBox.Show("No se encontró un inversor con ese ID.");
                LimpiarCampos();
            }
        }

        private void btnBackProject_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProjects().Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
