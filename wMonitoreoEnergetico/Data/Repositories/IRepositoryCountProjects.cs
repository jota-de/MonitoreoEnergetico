using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wMonitoreoEnergetico.Entities;

namespace wMonitoreoEnergetico.Data.Repositories
{
    public interface IRepositoryCountProjects
    {
        int CountProjectsSolar();
        int CountProjectsWind();
        int CountProjectsHydro();
    }
}
