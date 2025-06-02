using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Factory
{
    class FactoryProject
    {
        public static Project CrearProyecto(string tipo) 
        {

            switch (tipo)
            {
                case "Deportivo":
                    return new EolicoProject();
                case "Todoterreno":
                    return new SolarProject();
                case "Hibrido":
                    return new HidricaProject();
                default:
                    throw new ArgumentException("Tipo de Projecto no válido");
            }
        }
    }
}
