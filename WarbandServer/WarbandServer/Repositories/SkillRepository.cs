using WarbandServer.Models.Common;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

namespace WarbandServer.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        private readonly WarbandContext _context;
        public SkillRepository(WarbandContext warbandContext)
        {
            _context = warbandContext;
        }

        public Skill GetSkill(int id) 
        { 
            Skill skill = _context.Skill.FirstOrDefault(x => x.Id == id);
            return skill;
        }

        public List<Skill> GetAllSkills() => _context.Skill.ToList();
    }
}
