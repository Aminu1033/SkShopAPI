using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SKShopAPI.Entities
{
    public class Order
    {
        public Guid Id { get; set; } 
        [Required] 
        public int OrderNumber { get; set; }  
        public string ShopUserId { get; set; } 
        public List<CartItem> CartItems { get; set; } = new();
        [MaxLength(50)]
        public string OrderDate { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");

    }
}
