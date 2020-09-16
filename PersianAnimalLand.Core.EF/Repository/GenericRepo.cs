using Microsoft.EntityFrameworkCore;
using PersianAnimalLand.Core.Repository;
using System.Collections.Generic;
using System.Linq;

namespace PersianAnimalLand.Core.EF.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public DbSet<T> _dbSet;
        public GenericRepo(DbContext context) => _dbSet = context.Set<T>();

        public T Get(int id) => _dbSet.Find(id);
        public IEnumerable<T> GetAll() => _dbSet.ToList();

        public void Insert(T entity) => _dbSet.Add(entity);
        public void InsertRange(IEnumerable<T> entities) => _dbSet.AddRange(entities);

        public void Delete(T entity) => _dbSet.Remove(entity);
        public void DeleteRAnge(IEnumerable<T> entities) => _dbSet.RemoveRange(entities);
    }
}
