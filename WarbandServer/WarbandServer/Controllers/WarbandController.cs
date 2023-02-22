using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using WarbandServer.Models;
using WarbandServer.Repositories;
using WarbandServer.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WarbandServer.Controllers
{
    [Route("api")]
    public class WarbandController : ControllerBase
    {
        private readonly IWarbandRepository _warbandRepository;

        public WarbandController( IWarbandRepository warbandRepository)
        {
            _warbandRepository = warbandRepository;
        }
        [HttpGet("common/warbands/")]
        public IActionResult Get()
        {
            List<Warband> list = _warbandRepository.GetWarbands();
            if (list == null)
            {
                return NotFound();
            }
            return Ok(list);
        }
        [HttpGet("common/warbands/{id}")]
        public IActionResult Get(int id)
        {
            Warband warband = _warbandRepository.GetWarband(id);
            if (warband == null) 
            {
                return NotFound();
            }
            return Ok(warband);
        }

        [HttpPost("warbands/")]
        public IActionResult Post([FromBody] Warband warband)
        {
            if (warband.Credits < 0)
            {
                ModelState.AddModelError("Description", "Credit value must be 0 or positive integer");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            int id = _warbandRepository.GetWarbands().Count(); 
            if (warband == null)
            {
                return BadRequest();
            }
            _warbandRepository.AddWarband(warband);
            // TODO: AddWarband seems to replace all existing warbands with the new one. Figure this out
            
            MockRepo.Instance.AddWarband(new Models.Warband { Id = id, Name = warband.Name , Credits = warband.Credits});
            return Created(warband.Name.ToString(), warband);
        }

        [HttpPut("warbands/{id}")]
        public IActionResult Put([FromBody] Warband warband)
        {

            _warbandRepository.UpdateWarband(warband.Id, warband);
            //localWarbands = new List<Warband> { warband };
            /*if (localWarbands.Count > 0)
            {
                return NotFound();
            }*/
            return Ok();
        }

        [HttpDelete("warbands/{id}")]
        public IActionResult Delete(int id)
        {
            Warband targetWarband = _warbandRepository.GetWarbands().Find(c => c.Id == id);
            if (targetWarband == null)
            {
                return NotFound();
            }
            _warbandRepository.DeleteWarband(id);   
            return Ok(_warbandRepository.GetWarbands());
        }
    }
}
