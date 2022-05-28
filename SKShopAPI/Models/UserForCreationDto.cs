using Microsoft.AspNetCore.Identity;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class UserForCreationDto
    {
        [Required]
        [PersonalData]
        [MaxLength(150)]
        public string FirstName { get; set; }

        [Required]
        [PersonalData]
        [MaxLength(150)]
        public string LastName { get; set; }         

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [PersonalData]
        public string Address { get; set; }

        [PersonalData] 
        public string Zipcode { get; set; }
        [MaxLength(250)]
        public string ImgUrl { get; set; }
        [MaxLength(250)]
        public string ImgName { get; set; }

        //public ICollection<string> Roles { get; set; }

        public List<Order> Orders { get; set; } = new();

        [MaxLength(50)]
        public string RegisterDate { get; set; } = DateTimeOffset.UtcNow.ToLocalTime().ToString("r");

                
    }
}
