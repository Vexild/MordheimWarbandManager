using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarbandServer.Models.User;
using WarbandServer.Services;

namespace WarbandServer.Controllers
{
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController( IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet("users")]
        public IActionResult Get()
        {
            List<User> list = _userRepository.GetUsers();
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);

        }
    }
}
