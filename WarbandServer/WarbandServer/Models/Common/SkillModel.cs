using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarbandServer.Models.Common
{
    public class Skill
    {   
        public int Id { get; set; }
        [Required]
        public string SkillName { get; set; }
        [Required]
        public string SkillCategory { get; set; }
        [Required]
        public string SkillRule { get; set; }

    }

}
