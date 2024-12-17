using Food1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food1.Models
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int UserId { get; set; } // Foreign Key
        public string Role { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } // Navigation Property
    }
}

