using WarbandServer.Models;

namespace WarbandServer.Services
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
    }
}