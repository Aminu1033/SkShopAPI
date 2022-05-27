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
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}1.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  76, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}2.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  34, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}3.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}4.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}5.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}6.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}7.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}8.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}9.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}10.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}11.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}12.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}13.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}14.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}15.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}16.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}17.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}18.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}19.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}20.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}21.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}22.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}23.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}24.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}25.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}26.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}27.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}28.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}29.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
                },

                new Product()
                {
                    Id = Guid.NewGuid(), ShortDescription = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?", LongDescription = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", Name = "Sk Duoyo Bracelet", AmountAvailable =  108, CategoryId = Guid.Parse("e931604b-8cba-41ec-90fd-08d9c009e093"), Color = "Pink", Discount = 0.1, ImgUrl = $"{BaseUrl}30.jpg",  ImgName = "1.jpg", Price = 56.00M, IsHot = true, IsInstock = true, IsItemOfTheWeek = false, DateCreated = DateTimeOffset.UtcNow.ToString("r")
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
