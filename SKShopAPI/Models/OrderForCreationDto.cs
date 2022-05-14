using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class OrderForCreationDto
    { 
        [Required] 
        public int OrderNumber { get; set; }
        [MaxLength(13)]
        [Required]
        public string ShopUserId { get; set; }
        public List<CartItem> CartItems { get; set; } = new();
        [MaxLength(50)]
        public string OrderDate { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");

    }
}
