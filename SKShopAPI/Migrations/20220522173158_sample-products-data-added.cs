using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SKShopAPI.Migrations
{
    public partial class sampleproductsdataadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "106b31e1-a241-4a6d-a6e2-5f3b08ec00ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61d8eaa3-bb67-4622-a160-1eba57de9dd9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5eefd00b-7824-45d4-853f-8c3e47bb7a93"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82659aa3-4b78-477b-9cd1-d03e2cc4f7b1", "b38bfa04-3fd9-49a0-8f67-0a4002831669", "Administrator", "ADMINISTRATOR" },
                    { "7f41c946-b546-45fe-8ad0-6e8575a4c5f9", "aa624519-7212-42ee-8ace-fbb18e66965e", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AmountAvailable", "CategoryId", "Color", "DateCreated", "Discount", "ImgName", "ImgUrl", "IsHot", "IsInstock", "IsItemOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("2a78eaae-7519-42d3-91ef-650342766917"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/28.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("9bf390da-09d2-4e3d-b134-fc551d88b3ed"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/27.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("ce507147-d191-4c0c-aa1c-c72f7f52edab"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/26.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("ea9462f0-d63d-460e-92a2-781c9458eec0"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/25.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("bec06195-7f2c-4432-a076-418be31f340d"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/24.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("bc1ce0d7-92a4-4b03-88a9-470ad38f7679"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/23.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("4aab3acb-231f-4c8b-bbf4-4c4c4a354d82"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/22.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("0b9cd94c-28c2-4e15-8f7e-76eee6bcd282"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/21.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("438527f9-6330-4699-83a9-3294e743952e"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/20.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("4bc4343b-4be0-4d87-9159-c057c6e25881"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/19.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("9785bd88-bbd6-4194-909a-b25ec950f52c"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/18.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("016d621f-dbb9-4d30-97e5-c67d1df7006d"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/17.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("b6cf0e5a-9e1e-4324-9487-04334ee5d976"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/16.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("e18f417a-2497-49e4-bb14-9855384f9440"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/15.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("7af2bc9a-de1b-4f85-a60a-954d30e14513"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/14.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("5212ade5-7a04-4947-ac0f-7f04338940fe"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/13.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("a046e148-e09b-4c31-abd1-49c34df63ab4"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/12.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("abdb59ca-6286-4668-8552-96fde7910b0d"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/11.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("849d47dc-4dff-4ed8-a7a7-f19d6d57f0f9"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/10.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("04ff1fa6-223b-44c7-9bb0-218373a61451"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/9.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("18443c2f-2a73-433d-b07c-bec676fd54d1"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/8.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("24437a2d-9251-4b5e-8b47-fe5ed6be6df2"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/7.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("91991041-7c9b-4715-bcdb-8b165463cd4d"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/6.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("63feb0db-b5ec-47af-8bae-0a491e33745e"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/5.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("c1c78615-1559-4232-9dc3-dbcd6b33bbfe"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/4.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("be27e401-656a-46a8-bf19-558642a87615"), 34, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/3.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("85f8d933-14b5-43a5-8151-451d5bd2bf91"), 76, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/2.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("6a671375-5c8b-447e-8b41-97f0742ba671"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/1.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("91e620ea-7ce0-49ed-9470-a40a7887ade2"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/29.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("3424d726-9737-46b3-af70-79e07da5f592"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/30.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f41c946-b546-45fe-8ad0-6e8575a4c5f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82659aa3-4b78-477b-9cd1-d03e2cc4f7b1");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("016d621f-dbb9-4d30-97e5-c67d1df7006d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("04ff1fa6-223b-44c7-9bb0-218373a61451"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0b9cd94c-28c2-4e15-8f7e-76eee6bcd282"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("18443c2f-2a73-433d-b07c-bec676fd54d1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("24437a2d-9251-4b5e-8b47-fe5ed6be6df2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2a78eaae-7519-42d3-91ef-650342766917"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3424d726-9737-46b3-af70-79e07da5f592"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("438527f9-6330-4699-83a9-3294e743952e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4aab3acb-231f-4c8b-bbf4-4c4c4a354d82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4bc4343b-4be0-4d87-9159-c057c6e25881"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5212ade5-7a04-4947-ac0f-7f04338940fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("63feb0db-b5ec-47af-8bae-0a491e33745e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6a671375-5c8b-447e-8b41-97f0742ba671"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7af2bc9a-de1b-4f85-a60a-954d30e14513"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("849d47dc-4dff-4ed8-a7a7-f19d6d57f0f9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("85f8d933-14b5-43a5-8151-451d5bd2bf91"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91991041-7c9b-4715-bcdb-8b165463cd4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("91e620ea-7ce0-49ed-9470-a40a7887ade2"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9785bd88-bbd6-4194-909a-b25ec950f52c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9bf390da-09d2-4e3d-b134-fc551d88b3ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a046e148-e09b-4c31-abd1-49c34df63ab4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("abdb59ca-6286-4668-8552-96fde7910b0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b6cf0e5a-9e1e-4324-9487-04334ee5d976"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bc1ce0d7-92a4-4b03-88a9-470ad38f7679"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("be27e401-656a-46a8-bf19-558642a87615"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bec06195-7f2c-4432-a076-418be31f340d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c1c78615-1559-4232-9dc3-dbcd6b33bbfe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ce507147-d191-4c0c-aa1c-c72f7f52edab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e18f417a-2497-49e4-bb14-9855384f9440"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea9462f0-d63d-460e-92a2-781c9458eec0"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "106b31e1-a241-4a6d-a6e2-5f3b08ec00ed", "d9dde6ce-277a-4892-b3b6-196c7e184929", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "61d8eaa3-bb67-4622-a160-1eba57de9dd9", "119b961d-3644-437b-a2b4-a1e9ec638304", "User", "USER" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AmountAvailable", "CategoryId", "Color", "DateCreated", "Discount", "ImgName", "ImgUrl", "IsHot", "IsInstock", "IsItemOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[] { new Guid("5eefd00b-7824-45d4-853f-8c3e47bb7a93"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 15:00:05 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/1.jpg  c", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" });
        }
    }
}
