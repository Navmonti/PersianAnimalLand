using Microsoft.AspNetCore.Mvc;
using PersianAnimalLand.Domain.Entity;

namespace PersianAnimalLand.Api.Controllers
{
    [Route("api/User/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public IActionResult Login() {
            return Ok(null);
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return Ok(null);
        }
    }
}
