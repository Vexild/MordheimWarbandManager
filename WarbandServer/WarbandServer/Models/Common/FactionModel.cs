using System.ComponentModel.DataAnnotations;

namespace WarbandServer.Models.Common
{
    public class FactionModel
    {
        int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2)]
        public string Legality { get; set; }

    }
}
