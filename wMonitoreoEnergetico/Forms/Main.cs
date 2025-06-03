using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wMonitoreoEnergetico.Utils;
using wMonitoreoEnergetico.Services;
using SistemaGestionProductosMVC.Utils;
using wMonitoreoEnergetico.Forms;
using wMonitoreoEnergetico.Entities;
using wMonitoreoEnergetico.Data.Repositories;
using wMonitoreoEnergetico.Data.UnitOfWork;

namespace wMonitoreoEnergetico
{
    public partial class frmMain : KryptonForm
    {
        private readonly IUnitOfWork _uow = new UnitOfWork();
        public frmMain()
        {
            InitializeComponent();
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

        private void btnProjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            new frmProjects().Show();
        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblNameProject_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblValueHydro_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblValueSolar = _uow.
        }
    }
}
