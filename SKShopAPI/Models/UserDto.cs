using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Models
{
    public class UserDto
    {

        public string Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string ImgUrl { get; set; } 
        public string ImgName { get; set; }
        public string Zipcode { get; set; }
        public string RegisterDate { get; set; }
        public int NumberOfOrders { get; set; }
        public List<Order> Orders { get; set; }

    }
}
