using Microsoft.AspNetCore.Mvc;
using PersianAnimalLand.Domain.Entity;
using PersianAnimalLand.Services.Interfaces;

namespace PersianAnimalLand.Api.Controllers
{
    [Route("api/User/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        public IActionResult AddUser(User user)
        {
           // return Ok(_userService.add)
        }
       


    }
}
