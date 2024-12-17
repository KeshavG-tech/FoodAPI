using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Food1.Models
{
    public class FoodCategory
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public string Name { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; } // Navigation Property
    }
}
