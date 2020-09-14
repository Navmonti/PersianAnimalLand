using PersianAnimalLand.Core.ViewModel;
using PersianAnimalLand.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Services.Interfaces
{
    public interface IUserService
    {
        IResponse<User> UserLogin();
    }
}
