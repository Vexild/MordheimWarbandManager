using System.ComponentModel.DataAnnotations;

namespace WarbandServer.Models.Common
{
    public class UnitSpecialRuleModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Rule { get; set; }
    }
}
