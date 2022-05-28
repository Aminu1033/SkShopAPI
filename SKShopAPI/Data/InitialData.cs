using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.IO;
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
            var BaseUrl = "https://localhost:5001/img/";

            //var fileJSON = File.ReadAllText("data.json");
            //var products = System.Text.Json.JsonSerializer.Deserialize<List<Product>>(fileJSON);
            //Console.WriteLine(products);
            //return products;
            return new List<Product>()
            {
                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Sk Duoyo Bracelet",
                    AmountAvailable =  150,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Blue",
                    Discount = 0.3, 
                    ImgUrl = $"{BaseUrl}1.jpg", 
                    ImgName = "1.jpg",
                    Price = 56.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Golden Chain Bracelet",
                    AmountAvailable =  763, 
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Pink",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}2.jpg", 
                    ImgName = "2.jpg",
                    Price = 15.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Dark Wooven Bracelet",
                    AmountAvailable =  34, 
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Dark",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}3.jpg", 
                    ImgName = "3.jpg",
                    Price = 89.98M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Blue Chain Bracelet",
                    AmountAvailable =  786,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Blue",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}4.jpg", 
                    ImgName = "4.jpg",
                    Price = 199.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Casual Love Women Bracelet",
                    AmountAvailable =  560,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.15, 
                    ImgUrl = $"{BaseUrl}5.jpg", 
                    ImgName = "5.jpg",
                    Price = 96.50M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Men Wrist Bracelet",
                    AmountAvailable =  235,
                    CategoryId = Guid.Parse("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                    Color = "Blue",
                    Discount = 0.30, 
                    ImgUrl = $"{BaseUrl}6.jpg", 
                    ImgName = "6.jpg",
                    Price = 45.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "CK Pink",
                    AmountAvailable =  264,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Pink",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}7.jpg", 
                    ImgName = "7.jpg",
                    Price = 39.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Black Butter-Fly",
                    AmountAvailable =  900,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Black",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}8.jpg", 
                    ImgName = "8.jpg",
                    Price = 370.95M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Pink Chain Bracelet",
                    AmountAvailable =  209,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Pink",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}9.jpg", 
                    ImgName = "9.jpg",
                    Price = 56.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Golden Amulate",
                    AmountAvailable =  450,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Yellow",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}10.jpg",
                    ImgName = "10.jpg",
                    Price = 78.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Men Rhinestone",
                    AmountAvailable =  832,
                    CategoryId = Guid.Parse("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}11.jpg",
                    ImgName = "11.jpg",
                    Price = 23.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Yellow Love",
                    AmountAvailable =  345,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Yellow",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}12.jpg",
                    ImgName = "12.jpg",
                    Price = 99.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Red Butterfly Bracelet",
                    AmountAvailable =  543,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.15, 
                    ImgUrl = $"{BaseUrl}13.jpg",
                    ImgName = "13.jpg",
                    Price = 199.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Yellowish Butterfly Bracelet",
                    AmountAvailable =  890,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Yellow",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}14.jpg",
                    ImgName = "14.jpg",
                    Price = 86.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Green Local Weave Bracelet",
                    AmountAvailable = 564,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Green",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}15.jpg",
                    ImgName = "15.jpg",
                    Price = 156.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Red Local Weave Bracelet",
                    AmountAvailable = 183,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}16.jpg",
                    ImgName = "16.jpg",
                    Price = 73.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Gray Chain Bracelet",
                    AmountAvailable =  674,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Gray",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}17.jpg",
                    ImgName = "17.jpg",
                    Price = 109.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Golden Star Love Bracete",
                    AmountAvailable =  725,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Gold",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}18.jpg",
                    ImgName = "18.jpg",
                    Price = 130.98M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Light Pink Star Love Bracete",
                    AmountAvailable =  363,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Pink",
                    Discount = 0.0, 
                    ImgUrl = $"{BaseUrl}19.jpg",
                    ImgName = "19.jpg",
                    Price = 105.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Rhinestones Duoya Bracelet Watch",
                    AmountAvailable =  122,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Green",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}20.jpg",
                    ImgName = "20.jpg",
                    Price = 110.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Fan Teeda Love Bracelet",
                    AmountAvailable =  323,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Silver",
                    Discount = 0.13, 
                    ImgUrl = $"{BaseUrl}21.jpg",
                    ImgName = "21.jpg",
                    Price = 166.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Blood Red Duoya Bracelet",
                    AmountAvailable =  98,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Brown",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}22.jpg",
                    ImgName = "22.jpg",
                    Price = 96.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Green Duoya Chain Bracelet",
                    AmountAvailable =  160,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Green",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}23.jpg",
                    ImgName = "23.jpg",
                    Price = 77.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Red Duoya Chain Bracelet",
                    AmountAvailable =  675,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}24.jpg",
                    ImgName = "24.jpg",
                    Price = 89.97M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Fan Teeda Silver Rhinestone Bracelet",
                    AmountAvailable =  59,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Silver",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}25.jpg",
                    ImgName = "25.jpg",
                    Price = 259.00M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Fan Teeda Red Rhinestone Bracelet",
                    AmountAvailable =  800,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}26.jpg",
                    ImgName = "26.jpg",
                    Price = 278.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Fan Teeda Blood Red Rhinestone Bracelet",
                    AmountAvailable =  198,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.1, 
                    ImgUrl = $"{BaseUrl}27.jpg",
                    ImgName = "27.jpg",
                    Price = 199.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Fan Teeda Gray Rhinestone Bracelet",
                    AmountAvailable =  698,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "Gray",
                    Discount = 0.00, 
                    ImgUrl = $"{BaseUrl}28.jpg",
                    ImgName = "28.jpg",
                    Price = 200.00M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Brown Smart Watch",
                    AmountAvailable =  98,
                    CategoryId = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Color = "Brown",
                    Discount = 0.90,
                    ImgUrl = $"{BaseUrl}29.jpg",
                    ImgName = "29.jpg",
                    Price = 569.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                 new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "AZ Pentom Laptop",
                    AmountAvailable =  378,
                    CategoryId = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Color = "Silver",
                    Discount = 0.90,
                    ImgUrl = $"{BaseUrl}30.jpg",
                    ImgName = "30.jpg",
                    Price = 2499.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                 new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "White Smart Watch",
                    AmountAvailable =  198,
                    CategoryId = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Color = "White",
                    Discount = 0.30,
                    ImgUrl = $"{BaseUrl}31.jpg",
                    ImgName = "31.jpg",
                    Price = 899.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                   new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Slick Design Dake PC Laptop",
                    AmountAvailable =  38,
                    CategoryId = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Color = "Gray",
                    Discount = 0.00,
                    ImgUrl = $"{BaseUrl}32.jpg",
                    ImgName = "32.jpg",
                    Price = 2999.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                    new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "GLK 300 Android Phone",
                    AmountAvailable =  388,
                    CategoryId = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Color = "Gray",
                    Discount = 0.00,
                    ImgUrl = $"{BaseUrl}33.jpg",
                    ImgName = "33.jpg",
                    Price = 999.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },


                        new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "Red T-Shirt for men",
                    AmountAvailable =  218,
                    CategoryId = Guid.Parse("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                    Color = "Red",
                    Discount = 0.00,
                    ImgUrl = $"{BaseUrl}34.jpg",
                    ImgName = "34.jpg",
                    Price = 49.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                                 new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "White T-Shirt for Young",
                    AmountAvailable =  618,
                    CategoryId = Guid.Parse("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"),
                    Color = "White",
                    Discount = 0.00,
                    ImgUrl = $"{BaseUrl}35.jpg",
                    ImgName = "35.jpg",
                    Price = 29.99M,
                    IsHot = true,
                    IsInstock = true,
                    IsItemOfTheWeek = false,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },


                  new Product()
                {
                    Id = Guid.NewGuid(),
                    ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?",
                    LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!",
                    Name = "White T-Shirt for Women",
                    AmountAvailable =  918,
                    CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Color = "White",
                    Discount = 0.00,
                    ImgUrl = $"{BaseUrl}36.jpg",
                    ImgName = "36.jpg",
                    Price = 69.99M,
                    IsHot = false,
                    IsInstock = true,
                    IsItemOfTheWeek = true,
                    DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },
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
                    Description = "Fashion and Designers for men",
                },
                new Category()
                {
                    Id = Guid.Parse("aa920d5c-d44e-4d5c-90ff-08d9c009e093"),
                    Name = "Sports",
                    Description = "Products for sports"
                },
                new Category()
                {
                    Id = Guid.Parse("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"),
                    Name = "Young",
                    Description = "Fashion and Designer for Young People"
                },
                new Category()
                {
                    Id = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"),
                    Name = "Women",
                    Description = "Fashion and Designers for women"
                },
                new Category()
                {
                    Id = Guid.Parse("2868642b-8c0a-44ec-00fd-43d9c009e126"),
                    Name = "Gadgets",
                    Description = "Latest Quality Gadgets"
                }

            };
        }
    }
}
