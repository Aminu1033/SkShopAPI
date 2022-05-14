using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Entities
{
    public class CartItem
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; } = 1;

        public Guid ProductId { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string ProductName { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string ProductColor { get; set; }       

        [Range(1, int.MaxValue, ErrorMessage = "Price is required and cannot be 0")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal ProductPrice { get; set; }

        [Range(0.0, 0.9, ErrorMessage = "Discount is required and can only be between 0.0 and 0.9")]
        [Column(TypeName = "decimal(1,1)")]
        public decimal ProductDiscount { get; set; }

        public int ProductAmountAvailable { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string ProductImgUrl { get; set; }

        public bool ProductIsInstock { get; set; }  
        [MaxLength(50)]
        public string DateAdded { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");
    }
}