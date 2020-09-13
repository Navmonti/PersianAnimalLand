using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersianAnimalLand.Domain.Entity;

namespace PersianAnimalLand.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login()
        {
            return Ok(null);
        }

        [HttpPost]
        public IActionResult LogOut()
        {
            return Ok(null);
        }
    }
}