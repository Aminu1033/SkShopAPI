using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class OrderDto
    {
        public Guid Id { get; set; } 
        public int OrderNumber { get; set; }
        public string ShopUserId { get; set; }
        public List<CartItem> CartItems { get; set; } = new(); 
        public string OrderDate { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");

    }
}
