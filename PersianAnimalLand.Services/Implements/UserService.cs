using PersianAnimalLand.Core.ViewModel;
using PersianAnimalLand.Domain.Entity;
using PersianAnimalLand.Services.Interfaces; 

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
