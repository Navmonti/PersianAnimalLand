using System.Collections.Generic;

namespace PersianAnimalLand.Core.Repository
{
    public interface IGenericRepo<T>
    {
        T Get(int id);
        IEnumerable<T> GetAll();

        void Insert(T entity);
        void InsertRange(IEnumerable<T> entities);

        void Delete(T entity);
        void DeleteRAnge(IEnumerable<T> entities);
    }
}
