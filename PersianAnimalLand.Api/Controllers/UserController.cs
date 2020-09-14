using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersianAnimalLand.Domain.Entity;
using PersianAnimalLand.Services.Interfaces;

namespace PersianAnimalLand.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            var response = _userService.UserLogin();
            return Ok(null);
        }

        [HttpPost]
        public IActionResult LogOut()
        {
            return Ok(null);
        }
    }
}