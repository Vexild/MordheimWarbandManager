using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;

namespace WarbandServer.Controllers
{
    [Route("api")]
    public class UnitController : ControllerBase
    {

        private readonly IUnitRepository _unitRepository;
        public UnitController( IUnitRepository unitRepository)
        {
            _unitRepository = unitRepository;
        }

        [HttpGet("common/unit")]
        public IActionResult Get()
        {
            List<Unit> list = _unitRepository.GetAllUnits();
            return Ok(list);
        }
        [HttpGet("common/unit/{id}")]
        public IActionResult Get(int id)
        {
            Unit unit = _unitRepository.GetUnit(id);
            if (unit == null)
            {
                return NotFound();
            }
            return Ok(unit);

        }
    }
}
