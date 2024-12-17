using Food1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food1.Models
{
    public class Rating
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int UserId { get; set; } // Foreign Key to User
        public int RestaurantId { get; set; } // Foreign Key to Restaurant

        public int Stars { get; set; }
        public string Review { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } // Navigation Property

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; } // Navigation Property
    }
}
