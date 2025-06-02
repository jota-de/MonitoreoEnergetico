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

namespace wMonitoreoEnergetico.Forms
{
    public partial class frmConstructors : KryptonForm
    {
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
    }
}
