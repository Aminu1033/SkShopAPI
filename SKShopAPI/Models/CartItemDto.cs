using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class CartItemDto
    {
        public Guid Id { get; set; }
        public int Quantity { get; set; } = 1; 
        public Guid ProductId { get; set; } 
        public string ProductName { get; set; } 
        public string ProductColor { get; set; } 
        public decimal ProductPrice { get; set; } 
        public decimal ProductDiscount { get; set; } 
        public int ProductAmountAvailable { get; set; } 
        public string ProductImgUrl { get; set; } 
        public bool ProductIsInstock { get; set; } 
        public string DateAdded { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");
    }
}
