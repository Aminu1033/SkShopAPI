using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Entities
{ 
    public class Product
    { 
        public Guid Id { get; set; }

        [Required] 
        [Column(TypeName = "varchar(150)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Color { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string ShortDescription { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string LongDescription { get; set; }
         
        [Range(1, int.MaxValue, ErrorMessage = "Price is required and cannot be 0")]
        [Column(TypeName = "decimal(6,2)")]
        public decimal Price { get; set; }

        [Range(0.0, 0.9, ErrorMessage = "Discount is required and can only be between 0.0 and 0.9")]
        [Column(TypeName = "decimal(1,1)")]
        public decimal Discount { get; set; } 

        public int AmountAvailable { get; set; }         

        [Column(TypeName = "varchar(250)")]
        public string ImgUrl { get; set; }
         
        public bool IsInstock { get; set; }
         
        public bool IsItemOfTheWeek { get; set; }
         
        public bool IsHot { get; set; }
         
        public Category Category { get; set; } 

        public Guid CategoryId { get; set; }
        [MaxLength(50)]
        public string DateCreated { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");
    }
}
