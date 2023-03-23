using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarbandServer.Models.Common
{
    public class Unit
    {
        public int Id { get; set; }
        [Required]
        public int FactionId { get; set; }

        [Required]
        public string Name { get; set; }

        public int StartingExp { get; set; }

        public bool CombatSkill { get; set; }
        public bool ShootingSkill { get; set; }
        public bool AcademicSkill { get; set; }
        public bool StrengthSkill { get; set; }
        public bool SpeedSkill { get; set; }

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
