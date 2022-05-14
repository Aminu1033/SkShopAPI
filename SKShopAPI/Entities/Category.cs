using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SKShopAPI.Entities
{
    public class Category
    {
        public Guid Id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Description { get; set; }

        [JsonIgnore]
        public List<Product> Products { get; set; } = new();
    }
}
