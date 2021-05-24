using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoWithUnitOfWork.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Employee> emps { get; }

        IRepository<Department> depts { get; }

        void SaveDatabase();
    }
}
