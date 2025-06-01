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

namespace wMonitoreoEnergetico
{
    public partial class frmLogin : KryptonForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var auth = new AuthService();
            var usuario = auth.Login(txtUser.Text.Trim(), txtPassword.Text.Trim());

            if (usuario != null)
            {
                SesionUsuario.Actual = usuario;
                this.Hide();
                new frmMain().Show();
            }
            else
            {
                MessageBox.Show("Credenciales incorrectas.");
            }
        }
    }
}
