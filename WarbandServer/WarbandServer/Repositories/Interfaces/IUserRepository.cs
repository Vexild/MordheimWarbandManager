using WarbandServer.Models.User;

namespace WarbandServer.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetUsers();
        User GetUser(int id);
    }
}