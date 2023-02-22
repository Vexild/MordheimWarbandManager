using WarbandServer.Models;

namespace WarbandServer.Services
{
    public interface IWarbandRepository
    {
        Warband GetWarband(int id);
        List<Warband> GetWarbands();

        void AddWarband(Warband warband);
        void UpdateWarband(int id, Warband warband);
        void DeleteWarband(int id);

    }
}
