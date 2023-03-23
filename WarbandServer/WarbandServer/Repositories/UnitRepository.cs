using System.ComponentModel.DataAnnotations;
using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class UnitRepository : IUnitRepository
    {
        private readonly WarbandContext _context;
        public UnitRepository(WarbandContext warbandContext)
        {
            _context = warbandContext;
        }

        public Unit GetUnit(int id)
        {
            var unit = _context.Unit.FirstOrDefault(x => x.Id == id);
            return unit;
        }
        public List<Unit> GetAllUnits() => _context.Unit.ToList();
    }
}
