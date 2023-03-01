using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace WarbandServer.Models.Common
{
    public class UnitModel
    {
        public int Id { get; set; }
        [Required]
        public int FactionId { get; set; }

        [Required]
        public string Name { get; set; }

        public int StartingExp { get; set; }

        // this requires table with Skillgroups. Use skill group IDs instead of strings.
        public List<String> SkillGroups { get; set; } = new List<String>();

        public int Cost { get; set; }

        public int CostNotes { get; set; }
        public int MaxGroupSize { get; set; }
        public int UnitLimit { get; set; }
        
        [Required]
        public bool HiredSword { get; set; }

        // Characteristics
        [Required]
        [Range(0, int.MaxValue)]
        public int Movement { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int WSkill { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int BSkill { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Strength { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Toughness { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Wounds { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Initiative { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Attacks { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int LeaderShip { get; set; }

        // Max Characteristics
        [Range(1, int.MaxValue)]
        public int MaxMovement { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxWSkill { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxBSkill { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxStrength { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxToughness { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxWounds { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxInitiative { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxAttacks { get; set; }
        [Range(1, int.MaxValue)]
        public int MaxLeaderShip { get; set; }


    }
}
