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
    public class ProductForUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        [MaxLength(150)]
        [Required]
        public string ShortDescription { get; set; }

        [MaxLength(500)]
        public string LongDescription { get; set; }

        [Column(TypeName = "decimal(8,2)")]
        public decimal Price { get; set; }

        [Range(0, 1)]
        [Column(TypeName = "decimal(8,2)")]
        public decimal Discount { get; set; }
         
        public int AmountAvailable { get; set; }

        [MaxLength(250)]
        public string ImgUrl { get; set; }

        [MaxLength(250)]
        public string ImgName { get; set; }
        public bool IsInstock { get; set; }

        public bool IsItemOfTheWeek { get; set; }

        public bool IsHot { get; set; }
        
        public Guid CategoryId { get; set; }

        public string DateCreated { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");
    }
}
