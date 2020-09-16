using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Core.EF.DbContext
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChange();
    }
}
