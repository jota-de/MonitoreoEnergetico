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


namespace wMonitoreoEnergetico
{
    public partial class frmMain : KryptonForm
    {
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
    }
}
