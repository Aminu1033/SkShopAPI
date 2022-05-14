using Microsoft.AspNetCore.Identity;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Data
{
    public static class InitialData
    {
        public static IEnumerable<IdentityRole> GetRoles()
        {
            return new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                },
                new IdentityRole()
                {
                    Name = "User",
                    NormalizedName = "USER"
                }
                   
            };
        } 

        public static IEnumerable<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                
                }
                   
            };
        }

        public static IEnumerable<Category> GetCategories()
        {
            return new List<Category>()
            {
                new Category()
                {
                    Id = Guid.Parse("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                    Name = "Men",
                    Description = "Fine bracelets for men",
                },
                new Category()
                {
                    Id = Guid.Parse("aa920d5c-d44e-4d5c-90ff-08d9c009e093"),
                    Name = "Sports",
                    Description = "Bracelets for sports"
                },
                new Category()
                {
                    Id = Guid.Parse("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"),
                    Name = "Watches",
                    Description = "Fashion and Designer watches"
                },
                new Category()
                {
                    Id = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Name = "Women",
                    Description = "Fashion and Designer bracelets for women"
                }
                 
            };
        }
    }
}
