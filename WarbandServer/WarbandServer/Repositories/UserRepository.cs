using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Xml.Linq;
using WarbandServer.Models;
using WarbandServer.Models.User;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WarbandContext _context;
        private readonly IConfiguration _configuration;

        public UserRepository(WarbandContext warbandContext, IConfiguration configuration)
        {
            _context = warbandContext;
            _configuration = configuration;
        }

        public User GetUser(int id)
        {
            return _context.User.FirstOrDefault(c => c.Id == id);
        }

        public List<User> GetUsers() =>
            _context.User.ToList();

        public void AddUser(User user)
        {
            user.Pass = PasswordHasher.HashPassword(user.Pass);
            _context.User.Add(user);
            _context.SaveChanges();
        }
        
        public void UpdateUser(int id, User newInfo)
        {
            var user = GetUser(id);
            user.Name = newInfo.Name;
            user.Pass = newInfo.Pass;
            user.Mail = newInfo.Mail;
            user.PrivateUser = newInfo.PrivateUser;

            _context.User.Update(user);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            _context.User.Remove(GetUser(id));
            _context.SaveChanges();
        }

        public List<Warband> GetUserWarbands(int id)
        {
            List<Warband> listOfWarbands = new List<Warband>();
            listOfWarbands.Add(new Warband() { Id = 1, Name = "Middleheims mercs", Credits = 130, Rating = 100 });
            return listOfWarbands;
        }

        public string CreateToken(string userName, string password)
        {
            var key = Encoding.ASCII.GetBytes(_configuration["JWT:key"]);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, userName),
                }),
                Expires = DateTime.UtcNow.AddMinutes(10),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha512Signature)
            };
            var tokenhandler = new JwtSecurityTokenHandler();
            var token = tokenhandler.CreateToken(tokenDescriptor);
            string tokenString = tokenhandler.WriteToken(token);
            return tokenString;

        }
        public string Authenticate(string userName, string password)
        {
            try
            {
                var authenticationToken = CreateToken(userName, password);
                return authenticationToken;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
