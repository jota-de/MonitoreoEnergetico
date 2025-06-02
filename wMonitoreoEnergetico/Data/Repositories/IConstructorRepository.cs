using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public interface IConstructorRepository
    {
        List<Constructor> ObtenerTodos();
        void Insertar(Constructor constructor);
        void Actualizar(Constructor constructor);
        void Eliminar(short idConstructor);
        void ObtenerPorId(short idConstructor);

    }
}
