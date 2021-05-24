using DBLayer;
using Microsoft.EntityFrameworkCore;
using RepoWithUnitOfWork.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoWithUnitOfWork.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class 
    {
        private readonly EmployeeDbContext _dbContext;
        internal DbSet<T> dbSet;

        public GenericRepository(EmployeeDbContext dbContext)
        {
            _dbContext = dbContext;
            dbSet = _dbContext.Set<T>();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
            _dbContext.Entry(entity).State = EntityState.Added;
            //_dbContext.Add(dbSet);
        }

        public void Delete(int Id)
        {
            var entity = dbSet.Find(Id);
            dbSet.Remove(entity);
            _dbContext.Entry(entity).State = EntityState.Deleted;
        }

        public IEnumerable<T> Get()
        {
            return dbSet.ToList();
        }

        public T Get(int Id)
        {
            return dbSet.Find(Id);
        }

        public void Insert(T entity)
        {
            dbSet.Add(entity);
        }

        public void update(T entity)
        {
            dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}
