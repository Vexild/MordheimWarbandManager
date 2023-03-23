using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarbandServer.Models.Common
{
    public class Faction
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2)]
        public string Legality { get; set; }

        public int StartingGold { get; set; }

        [Required]
        public int MinimumWarriors{ get; set; }
        [Required]
        public int MaximumWarriors { get; set; }


        public string Description { get; set; }

        [Required]
        [MaxLength(600)]
        public string SpecialRule { get; set; }

    }
}
