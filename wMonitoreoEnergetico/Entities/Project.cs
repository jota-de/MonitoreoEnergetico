using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wMonitoreoEnergetico.Entities
{
    // Clase base
    public  class Project
    {
        public short idProyecto { get; set; }
        public string nombreProyecto { get; set; }
        public string codigoProyecto { get; set; }
        public string tipoGeneracion { get; set; }
        public short numeroUnidades { get; set; }
        public string departamento { get; set; }
        public string municipio { get; set; }
        public double capacidadInstalada { get; set; }
        public short idInversor { get; set; }
        public short idEmpresa { get; set; }
    }

    // Subclase para proyectos eólicos
    public class EolicoProject : Project
    {
        //  agregar propiedades específicas aquí
    }

    // Subclase para proyectos solares
    public class SolarProject : Project
    {
        //  agregar propiedades específicas aquí
    }

    // Subclase para proyectos hídricos
    public class HidricaProject : Project
    {
        //  agregar propiedades específicas aquí
    }
}
