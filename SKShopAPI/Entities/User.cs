using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SKShopAPI.Entities
{
    public class User : IdentityUser
    { 
        public override string Id { get; set; }
        [Required]
        [PersonalData]
        [Column(TypeName = "varchar(150)")]
        public string FirstName { get; set; }
        [Required]
        [PersonalData]
        [Column(TypeName = "varchar(150)")]
        public string LastName { get; set; } 
        [PersonalData]
        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(250)")]
        public string ImgUrl { get; set; }
        [PersonalData]
        [Column(TypeName = "varchar(10)")]
        public string Zipcode { get; set; }
        [MaxLength(50)]
        public string RegisterDate { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");
        public List<Order> Orders { get; set; } = new(); 

    }
}
