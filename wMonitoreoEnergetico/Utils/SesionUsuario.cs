
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace SistemaGestionProductosMVC.Utils
{
    public static class SesionUsuario
    {
        public static Usuario Actual { get; set; }
    }
}