using WarbandServer.Models.Common;

namespace WarbandServer.Repositories.Interfaces
{
    public interface ISkillRepository
    {
        Skill GetSkill(int skillId);
        List<Skill> GetAllSkills();
    }
}
