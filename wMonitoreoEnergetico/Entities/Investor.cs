using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wMonitoreoEnergetico.Entities
{
    public class Investor
    {
        public short idInversor { get; set; }
        public string nombreInversor { get; set; } 
        public string codigoInversor { get; set; }
        public string tipoInversor { get; set; }  
        public string paisOrigenInversor { get; set; } 
        public string emailInversor { get; set; } 
        public int telefonoInversor { get; set; } 
    }
}
