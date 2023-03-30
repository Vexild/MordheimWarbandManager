using System.ComponentModel.DataAnnotations;
using WarbandServer.Models;
using WarbandServer.Models.User;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly WarbandContext _context;
        public UserRepository(WarbandContext warbandContext)
        {
            _context = warbandContext;

        }

        public User GetUser(int id)
        {
            return _context.User.FirstOrDefault(c => c.Id == id);
        }

        public List<User> GetUsers() =>
            _context.User.ToList();

        public void AddUser(User user)
        {
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
    }
}
