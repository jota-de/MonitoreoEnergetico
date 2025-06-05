using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public interface IuserRepository
    {
        List<Usuario> ObtenerTodos();
       // void Insertar(Usuario producto);
        //void Actualizar(Usuario producto);
        void Eliminar(Usuario usuario);
    }
}
