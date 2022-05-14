using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class CategoryForCreationDto
    { 
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        [Required]
        public string Description { get; set; }

        // public List<Product> Products { get; set; } = new();
    }
}
