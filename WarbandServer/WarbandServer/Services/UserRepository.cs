using System.ComponentModel.DataAnnotations;
using WarbandServer.Models.User;

namespace WarbandServer.Services
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
            var user = _context.User.FirstOrDefault(c => c.Id == id);
            return user;
        }

        public List<User> GetUsers() =>
            _context.User.ToList();

        public void AddUser(User user) { 
        
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
    }
}
