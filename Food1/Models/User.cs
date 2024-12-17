using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Food1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; } // Navigation Property
    }
}
