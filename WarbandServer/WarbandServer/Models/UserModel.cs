using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WarbandServer.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Pass { get; set; }
        [Required]
        [MaxLength(255)]
        public string Mail { get; set; }
        [DefaultValue(false)]
        public bool PrivateUser { get; set; }

        public DateTime Joined { get; set; } = DateTime.UtcNow;

    }
}
