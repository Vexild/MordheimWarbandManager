using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;

namespace WarbandServer.Controllers
{
    [Route("Api")]
    public class FactionController : ControllerBase
    {
        private readonly IFactionRepository _factionRepository;
        public FactionController(IFactionRepository factionRepository)
        {
            _factionRepository = factionRepository;
        }

        [HttpGet("/faction")]
        public IActionResult Get()
        {
            List<Faction> list = _factionRepository.GetAllFactions();
            return Ok(list);
        }

        [HttpGet("/faction/{id}")]
        public IActionResult Get(int id)
        {
            Faction faction = _factionRepository.GetFaction(id);
            if (faction == null)
            {
                return NotFound();
            }
            return Ok(faction);
        }
    }
}
