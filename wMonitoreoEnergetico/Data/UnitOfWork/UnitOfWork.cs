﻿using System;
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
        public IConstructorRepository constructorRepository { get; }
        public IProjectRepository ProjectRepository { get; }
        public IRepositoryCountProjects RepositoryCountProjects { get; }
        public IuserRepository UserRepository { get; }


        public UnitOfWork()
        {
            InvestorRepository = new InvestorRepository();
            constructorRepository = new ConstructorRepository();
            ProjectRepository = new ProjectRespository();
            RepositoryCountProjects = new RepositoryCountProjects();
            UserRepository = new UserRepository();

        }
    }
}
