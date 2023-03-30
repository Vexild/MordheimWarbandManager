using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarbandServer.Models.User
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
        [MaxLength(255)]
        public string Mail { get; set; }
        [DefaultValue(false)]
        public bool PrivateUser { get; set; }

        public DateTime Joined { get; set; } = DateTime.UtcNow;

    }
}
