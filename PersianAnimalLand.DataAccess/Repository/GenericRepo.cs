using Microsoft.EntityFrameworkCore;
using PersianAnimalLand.Core.Repository;
using PersianAnimalLand.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersianAnimalLand.DataAccess.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        public DbSet<T> _dbSet;
        public GenericRepo(DbContext context) => _dbSet = context.Set<T>();

        public void Save(T model) => _dbSet.Add(model);

        public void Updare(T model) => _dbSet.Update(model);

        public void Delete(T model) => _dbSet.Remove(model);
        
        public void SaveRange(List<T> models) => _dbSet.AddRange(models);

        public void UpdareRange(List<T> models) => _dbSet.UpdateRange(models);

        public void DeleteRange(T model) => _dbSet.RemoveRange(model);

    }
}
