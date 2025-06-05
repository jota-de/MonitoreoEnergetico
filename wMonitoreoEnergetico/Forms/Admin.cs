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
    public partial class frmAdmin : KryptonForm 
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        private short? UserSeleccionadoID = null;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            CargarUsers();
        }
        private void CargarUsers()
        {
            var projects = _uow.UserRepository.ObtenerTodos();
            dgvUsers.DataSource = projects;
            dgvUsers.ClearSelection();
        }

        private void btnBackUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmMain().Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
