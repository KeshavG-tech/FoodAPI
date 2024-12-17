using Food1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Food1.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; } // Primary Key

        public int UserId { get; set; } // Foreign Key

        public DateTime OrderDate { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; } // Navigation Property

        public virtual ICollection<OrderDetail> OrderDetails { get; set; } // Navigation Property
    }
}
