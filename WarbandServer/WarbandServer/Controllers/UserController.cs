using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Cryptography;
using WarbandServer.Models;
using WarbandServer.Models.User;
using WarbandServer.Repositories;
using WarbandServer.Repositories.Interfaces;

namespace WarbandServer.Controllers
{
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;

        public UserController(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        [HttpGet("user")]
        public IActionResult Get()
        {
            List<User> list = _userRepository.GetUsers();
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);

        }

        [HttpGet("user/{id}")]
        public IActionResult GetUser(int id)
        {
            User user = _userRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("user")]
        public IActionResult PostUser(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                _userRepository.AddUser(user);
                return Ok();
            }
        }

        [HttpDelete("user")]
        public IActionResult DeleteUser(int id) 
        {
            if(id == 0)
            {
                return BadRequest("Can't find user id "+id);
            }
            else
            {
                _userRepository.DeleteUser(id);
                return Ok("Deleted user id "+id);
            }
        }

        [HttpPut("user")]
        public IActionResult PutUser(User user)
        {
            if(user == null)
            {
                return BadRequest();
            }
            else
            {
                _userRepository.UpdateUser(user.Id, user);
                return Ok(user);
            }
        }


        [HttpPost("login")]
        public IActionResult LoginUser(string userName, string password)
        {
            if (userName == null || password == null)
            {
                return BadRequest();
            }
            else
            {
                var key = _userRepository.Authenticate(userName, password);
                if (key == null) 
                {
                    return BadRequest();
                }
                return Ok(key);
            }
        }
    }
}
