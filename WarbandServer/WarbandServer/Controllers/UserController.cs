using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarbandServer.Models;
using WarbandServer.Models.User;
using WarbandServer.Repositories.Interfaces;

namespace WarbandServer.Controllers
{
    [Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
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
        public IActionResult Get(int id)
        {
            User user = _userRepository.GetUser(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost("user")]
        public IActionResult Post(User user)
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
        public IActionResult Delete(int id) 
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
        public IActionResult Put(User user)
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
        public IActionResult Post(string password, string username)
        {
            if(username == null || password == null)
            {
                return BadRequest();
            }
            else
            {
                // creater Authentication token here
                
                return Ok(user);
            }
        }
    }
}
