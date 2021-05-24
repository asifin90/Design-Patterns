using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoWithUnitOfWork.Interface
{
    public interface IRepository<T>
    {
        void Add(T entity);

        void Delete(int Id);

        IEnumerable<T> Get();

        T Get(int Id);        
    }
}
