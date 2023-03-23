using Microsoft.AspNetCore.Mvc;
using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;

namespace WarbandServer.Controllers
{
    [Route("Api")]
    public class SkillController : ControllerBase
    {
        private readonly ISkillRepository _skillRepository;
        public SkillController(ISkillRepository skillRepository)
        {
            _skillRepository = skillRepository;
        }

        [HttpGet("/skill")]
        public IActionResult Get()
        {
            List<Skill> list = _skillRepository.GetAllSkills();
            return Ok(list);
        }

        [HttpGet("/skill/{id}")]
        public IActionResult Get(int id)
        {
            Skill skill = _skillRepository.GetSkill(id);
            if (skill == null)
            {
                return NotFound();
            }
            return Ok(skill);
        }
    }
}
