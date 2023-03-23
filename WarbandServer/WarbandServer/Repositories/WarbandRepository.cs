using System.ComponentModel.DataAnnotations;
using WarbandServer.Models;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class WarbandRepository : IWarbandRepository
    {
        private readonly WarbandContext _context;
        public WarbandRepository(WarbandContext warbandContext)
        {
            _context = warbandContext;

        }

        // Move this data to DB once table is ready
        private static List<Warband> Warbands = new List<Warband>
        {
            new Warband{ Id=0, Name= "Kislev Mercenaries", Credits= 500 },
            new Warband{ Id=1, Name= "Dwarven Hunters", Credits= 500 },
            new Warband{ Id=2, Name= "Skaven Dreadrunners", Credits= 500 },
            new Warband{ Id=3, Name= "Ratslayers", Credits= 500 },
            new Warband{ Id=4, Name= "Undead Shamblers", Credits= 500 }
        };
        public void AddWarband(Warband warband) => Warbands.Add(warband);

        public void DeleteWarband(int id) => Warbands = Warbands.Where(c => c.Id != id).ToList();

        public Warband GetWarband(int id) => Warbands.FirstOrDefault(c => c.Id == id);

        public List<Warband> GetWarbands() => Warbands;

        public void UpdateWarband(int id, Warband modifiedWarband)
        {
            Warbands = Warbands.Select(c => c.Id == id ? c : modifiedWarband).ToList();
        }

    }
}
