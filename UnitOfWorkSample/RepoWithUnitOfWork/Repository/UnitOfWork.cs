using DBLayer;
using Models;
using RepoWithUnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoWithUnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeDbContext dbContext;

        public UnitOfWork(EmployeeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
       

        public IRepository<Employee> emps => new GenericRepository<Employee>(dbContext);

        public IRepository<Department> depts => new GenericRepository<Department>(dbContext);

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveDatabase()
        {
            dbContext.SaveChanges();
        }
    }
}
