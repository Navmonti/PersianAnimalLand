using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Core.Repository
{
    public interface IGenericRepo<T> 
    {
        void Save(T model);

        void Updare(T model);

       void Delete(T model);

       void SaveRange(List<T> models);

       void UpdareRange(List<T> models);

       void DeleteRange(T model);
    }
}
