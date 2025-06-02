using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Data.Repositories
{
    internal interface IInvestorRepository
    {
        List<Investor> ObtenerTodos();
        void Insertar(Investor inversor);
        void Actualizar(Investor inversor);
        void Eliminar(short idInversor);
    }
}
