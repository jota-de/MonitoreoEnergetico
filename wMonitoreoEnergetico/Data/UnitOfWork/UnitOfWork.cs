using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Data.Repositories;

namespace wMonitoreoEnergetico.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IInvestorRepository InvestorRepository { get; }

        public UnitOfWork()
        {
            InvestorRepository = new InvestorRepository();
        }
    }
}
