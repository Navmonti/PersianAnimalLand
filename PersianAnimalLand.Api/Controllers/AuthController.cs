using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersianAnimalLand.Services.Interfaces;

namespace PersianAnimalLand.Api.Controllers
{
    [Route("api/Auth/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            var x = _userService.
            return Ok();
        }

        [HttpPost]
        public IActionResult Logout()
        {
            return Ok(null);
        }

    }
}