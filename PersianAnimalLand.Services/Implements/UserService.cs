using PersianAnimalLand.Core.ViewModel;
using PersianAnimalLand.Domain.Entity;
using PersianAnimalLand.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersianAnimalLand.Services.Implements
{
    public class UserService : IUserService
    {
        public IResponse<User> UserLogin() {

            var response = new Response<User>();

            return response;
        }

    }
}
