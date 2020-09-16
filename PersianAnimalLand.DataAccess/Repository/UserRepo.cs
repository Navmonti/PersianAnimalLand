using PersianAnimalLand.Core.EF.Repository; 
using PersianAnimalLand.DataAccess.Context;
using PersianAnimalLand.DataAccess.IRepository;
using PersianAnimalLand.Domain.Entity; 

namespace PersianAnimalLand.DataAccess.Repository
{
    public class UserRepo : GenericRepo<User>, IUserRepo 
    {
        public UserRepo(PersianAnimalLandContext context) : base(context)
        {

        }
    }
}
