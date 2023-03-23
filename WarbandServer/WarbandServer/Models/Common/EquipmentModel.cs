using System.ComponentModel.DataAnnotations;

namespace WarbandServer.Models.Common
{
    public class EquipmentModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Cost { get; set; }
        public string CostNotes { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
    }
}
