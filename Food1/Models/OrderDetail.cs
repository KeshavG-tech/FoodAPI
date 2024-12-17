using Food1.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.UI.WebControls;

namespace Food1.Models
{
    public class OrderDetail
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int OrderId { get; set; } // Foreign Key
        public int MenuItemId { get; set; } // Foreign Key

        public int Quantity { get; set; }
        public decimal Price { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; } // Navigation Property

        [ForeignKey("MenuItemId")]
        public virtual MenuItem MenuItem { get; set; } // Navigation Property
    }
}
