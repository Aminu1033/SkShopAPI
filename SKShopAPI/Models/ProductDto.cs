using Microsoft.AspNetCore.Http;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class ProductDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string ShortDescription { get; set; } 
        public string LongDescription { get; set; } 
        public decimal Price { get; set; }
        public int AmountAvailable { get; set; }  
        public decimal Discount { get; set; }
        public string ImgUrl { get; set; } 
        public bool IsInstock { get; set; } 
        public bool IsItemOfTheWeek { get; set; }
        public bool IsHot { get; set; }
        public string CategoryName { get; set; }
        public Guid CategoryId { get; set; }
        public string DateCreated { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r"); 
    }
}
