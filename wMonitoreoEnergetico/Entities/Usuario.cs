﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wMonitoreoEnergetico.Entities
{
    public  class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Rol { get; set; }
        public string Contrasena { get; set; }


    }

    /*
    public class Adminstrador : Usuario { 
        
    }
    public class Vendedor : Usuario { }
    */
}