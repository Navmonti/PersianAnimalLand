using PersianAnimalLand.Core.EF.DbContext;
using PersianAnimalLand.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.DataAccess.UnitOfWork
{
    public class PersianAnimalLandUnitOfWork : IUnitOfWork
    {
        private readonly PersianAnimalLandContext _persianAnimalLandContext; 
        public PersianAnimalLandUnitOfWork(PersianAnimalLandContext persianAnimalLandContext)
        {
            _persianAnimalLandContext = persianAnimalLandContext;
        }

        public void Dispose()
        {
        }

        public int SaveChange()
        {
            return 0;
        }
    }
}
