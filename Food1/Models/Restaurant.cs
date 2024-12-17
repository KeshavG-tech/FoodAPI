using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.UI.WebControls;

namespace Food1.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public string Name { get; set; }
        public string Address { get; set; }

        public virtual ICollection<MenuItem> MenuItems { get; set; } // Navigation Property
        public virtual ICollection<Rating> Ratings { get; set; } // Navigation Property
    }
}
