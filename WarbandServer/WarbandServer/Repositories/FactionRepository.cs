using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class FactionRepository : IFactionRepository
    {
        private readonly WarbandContext _context;
        public FactionRepository(WarbandContext warbandContext) 
        {
            _context = warbandContext;
        }
        public Faction GetFaction(int id) => _context.Faction.FirstOrDefault(c => c.Id == id);
            
        public List<Faction> GetAllFactions() => _context.Faction.ToList();
    }
}
