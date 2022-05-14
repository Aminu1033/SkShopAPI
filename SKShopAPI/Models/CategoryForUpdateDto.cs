using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class CategoryForUpdateDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(150)]
        [Required]
        public string Description { get; set; }
    }
}
