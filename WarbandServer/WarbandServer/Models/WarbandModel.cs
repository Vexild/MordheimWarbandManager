using System.ComponentModel.DataAnnotations;

namespace WarbandServer.Models
{
    public class Warband
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int Credits { get; set; }
        [Required]
        public int Rating { get; set; }

    }
}
