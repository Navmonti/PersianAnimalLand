using PersianAnimalLand.Core.Repository;
using PersianAnimalLand.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.DataAccess.Repository
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        //public GenericRepo(PersianAnimalLandContext serviceDeskDbContext) : base(serviceDeskDbContext) { }
    }
}
