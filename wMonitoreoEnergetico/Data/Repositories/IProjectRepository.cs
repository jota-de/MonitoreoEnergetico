using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public interface IProjectRepository
    {
        List<Project> ObtenerTodos();
        void Insertar(Project project);
        void Actualizar(Project project);
        void Eliminar(short id);
    }
}
