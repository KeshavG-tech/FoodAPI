using Food1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food1.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int RestaurantId { get; set; } // Foreign Key
        public int FoodCategoryId { get; set; } // Foreign Key

        public string Name { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("RestaurantId")]
        public virtual Restaurant Restaurant { get; set; } // Navigation Property

        [ForeignKey("FoodCategoryId")]
        public virtual FoodCategory FoodCategory { get; set; } // Navigation Property
    }
}
