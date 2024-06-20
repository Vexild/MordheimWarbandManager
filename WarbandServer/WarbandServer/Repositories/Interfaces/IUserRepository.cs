using WarbandServer.Models;
using WarbandServer.Models.User;

namespace WarbandServer.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
        void AddUser(User user);
        void DeleteUser(int id);
        void UpdateUser(int id, User user);
        string CreateToken(User user);
        string Authenticate(string userName, string password);
    }
}