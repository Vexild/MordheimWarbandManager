using WarbandServer.Models.User;

namespace WarbandServer.Services
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
    }
}