
using WarbandServer.Models.Common;

namespace WarbandServer.Repositories.Interfaces
{
    public interface IUnitRepository
    {
        Unit GetUnit(int id);
        List<Unit> GetAllUnits();
        

    }
}
