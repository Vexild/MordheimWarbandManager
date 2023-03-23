using WarbandServer.Models.Common;

namespace WarbandServer.Repositories.Interfaces
{
    public interface IFactionRepository
    {
        List<Faction> GetAllFactions();
        Faction GetFaction(int id);
    }
}
