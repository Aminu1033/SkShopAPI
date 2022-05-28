using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SKShopAPI.Migrations
{
    public partial class more_initial_products_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { "94ae6d62-c563-42d0-906b-a45c7b8966eb", "52b6c560-306c-4742-8156-db317ea5fe9e", "Administrator", "ADMINISTRATOR" },
                    { "3e6f226d-045f-42f0-9938-90fc167ff379", "bb7312fa-dead-4109-abfc-e76cfa26b804", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fashion and Designer for Young People", "Young" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                column: "Description",
                value: "Fashion and Designers for men");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa920d5c-d44e-4d5c-90ff-08d9c009e093"),
                column: "Description",
                value: "Products for sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"),
                column: "Description",
                value: "Fashion and Designers for women");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "Latest Quality Gadgets", "Gadgets" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AmountAvailable", "CategoryId", "Color", "DateCreated", "Discount", "ImgName", "ImgUrl", "IsHot", "IsInstock", "IsItemOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("58e507b9-0598-4b27-937a-90e15e4fd297"), 786, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Blue", "Sat, 28 May 2022 00:09:42 GMT", 0m, "4.jpg", "https://localhost:5001/img/4.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Blue Chain Bracelet", 199.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("f5a1bba2-b431-44d2-9aab-1c99b98cff7c"), 150, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Blue", "Sat, 28 May 2022 00:09:42 GMT", 0.3m, "1.jpg", "https://localhost:5001/img/1.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("efb817a1-eb23-4c5f-864a-400652d68c49"), 918, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "White", "Sat, 28 May 2022 00:09:42 GMT", 0m, "36.jpg", "https://localhost:5001/img/36.jpg", false, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "White T-Shirt for Women", 69.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("b83d25dd-1340-4e03-b9b7-12ed2bcfb328"), 618, new Guid("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"), "White", "Sat, 28 May 2022 00:09:42 GMT", 0m, "35.jpg", "https://localhost:5001/img/35.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "White T-Shirt for Young", 29.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("72f9bac4-136e-4a64-815d-e4361517830d"), 218, new Guid("357fb7c4-b49a-4b78-90fe-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0m, "34.jpg", "https://localhost:5001/img/34.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Red T-Shirt for men", 49.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("06c43706-c835-425d-8db6-893f5857e927"), 698, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Gray", "Sat, 28 May 2022 00:09:42 GMT", 0m, "28.jpg", "https://localhost:5001/img/28.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Fan Teeda Gray Rhinestone Bracelet", 200.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("ed6da7cb-f541-478e-954e-e04625a17165"), 198, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "27.jpg", "https://localhost:5001/img/27.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Fan Teeda Blood Red Rhinestone Bracelet", 199.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("e19f9012-2dab-4627-b1d4-abeacf4f02f7"), 800, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0m, "26.jpg", "https://localhost:5001/img/26.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Fan Teeda Red Rhinestone Bracelet", 278.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("43795276-ba28-4b0a-8b50-ad8fbf71e4ba"), 59, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Silver", "Sat, 28 May 2022 00:09:42 GMT", 0m, "25.jpg", "https://localhost:5001/img/25.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Fan Teeda Silver Rhinestone Bracelet", 259.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("e37d247b-6b79-49da-a1ca-1c3679d2f9af"), 675, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0m, "24.jpg", "https://localhost:5001/img/24.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Red Duoya Chain Bracelet", 89.97m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("0922c952-8fc6-4ac3-8e39-7c4ffd6bd08d"), 160, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Green", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "23.jpg", "https://localhost:5001/img/23.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Green Duoya Chain Bracelet", 77.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("ea9c0fd4-b526-4661-a602-d78616322673"), 98, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Brown", "Sat, 28 May 2022 00:09:42 GMT", 0m, "22.jpg", "https://localhost:5001/img/22.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Blood Red Duoya Bracelet", 96.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("6094ed7d-2642-4c71-b72c-260af4a9b059"), 323, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Silver", "Sat, 28 May 2022 00:09:42 GMT", 0.13m, "21.jpg", "https://localhost:5001/img/21.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Fan Teeda Love Bracelet", 166.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("682c2f5b-7ae4-49fb-9d8f-adf222302174"), 122, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Green", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "20.jpg", "https://localhost:5001/img/20.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Rhinestones Duoya Bracelet Watch", 110.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("6c8040ce-4e5c-452e-b476-e046cbcf0489"), 363, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sat, 28 May 2022 00:09:42 GMT", 0m, "19.jpg", "https://localhost:5001/img/19.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Light Pink Star Love Bracete", 105.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("01ca406b-4a58-4fa5-b8c4-2fae4d0dc5c5"), 725, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Gold", "Sat, 28 May 2022 00:09:42 GMT", 0m, "18.jpg", "https://localhost:5001/img/18.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Golden Star Love Bracete", 130.98m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("afacfdc4-302a-470e-bbe5-c6c28147a50c"), 674, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Gray", "Sat, 28 May 2022 00:09:42 GMT", 0m, "17.jpg", "https://localhost:5001/img/17.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Gray Chain Bracelet", 109.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("f79e4a2b-e664-4cd1-a3c2-f6245c43efed"), 763, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sat, 28 May 2022 00:09:42 GMT", 0m, "2.jpg", "https://localhost:5001/img/2.jpg", false, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Golden Chain Bracelet", 15.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("35086945-8527-4ee9-8f40-f267928563d0"), 564, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Green", "Sat, 28 May 2022 00:09:42 GMT", 0m, "15.jpg", "https://localhost:5001/img/15.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Green Local Weave Bracelet", 156.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("8a28435a-f452-4f5a-a37f-bd446e263ded"), 890, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Yellow", "Sat, 28 May 2022 00:09:42 GMT", 0m, "14.jpg", "https://localhost:5001/img/14.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Yellowish Butterfly Bracelet", 86.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("3b13a409-4421-4ddc-90dd-82387d2f254b"), 543, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0.15m, "13.jpg", "https://localhost:5001/img/13.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Red Butterfly Bracelet", 199.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("767bb381-f535-4d43-b87d-b97730b53a4a"), 345, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Yellow", "Sat, 28 May 2022 00:09:42 GMT", 0m, "12.jpg", "https://localhost:5001/img/12.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Yellow Love", 99.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("d3aff2f8-4951-4a5c-a382-d417365dfb1d"), 832, new Guid("357fb7c4-b49a-4b78-90fe-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "11.jpg", "https://localhost:5001/img/11.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Men Rhinestone", 23.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("cd48196a-c4ab-44ce-8ef6-21e67bedc7a4"), 450, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Yellow", "Sat, 28 May 2022 00:09:42 GMT", 0m, "10.jpg", "https://localhost:5001/img/10.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Golden Amulate", 78.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("ad74ac6e-1ba0-4931-a065-12c761d1601b"), 209, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "9.jpg", "https://localhost:5001/img/9.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Pink Chain Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("7b7eb870-4168-46a5-8c8e-8d77a631c2b9"), 900, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Black", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "8.jpg", "https://localhost:5001/img/8.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Black Butter-Fly", 370.95m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("5568b375-5296-41cb-8da8-71f952644132"), 264, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sat, 28 May 2022 00:09:42 GMT", 0m, "7.jpg", "https://localhost:5001/img/7.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "CK Pink", 39.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("5c92ad2f-06c1-40c2-8c7e-43385d3a37af"), 235, new Guid("357fb7c4-b49a-4b78-90fe-08d9c009e093"), "Blue", "Sat, 28 May 2022 00:09:42 GMT", 0.3m, "6.jpg", "https://localhost:5001/img/6.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Men Wrist Bracelet", 45.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("0bbf2fa3-f001-4fa9-8009-0ed5320a7956"), 560, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0.15m, "5.jpg", "https://localhost:5001/img/5.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Casual Love Women Bracelet", 96.50m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("7b30f49b-d015-43cd-833f-d52f46bc4175"), 34, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Dark", "Sat, 28 May 2022 00:09:42 GMT", 0.1m, "3.jpg", "https://localhost:5001/img/3.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Dark Wooven Bracelet", 89.98m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("4326175e-654c-4b59-8639-cce104098fd3"), 183, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Red", "Sat, 28 May 2022 00:09:42 GMT", 0m, "16.jpg", "https://localhost:5001/img/16.jpg", false, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Red Local Weave Bracelet", 73.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AmountAvailable", "CategoryId", "Color", "DateCreated", "Discount", "ImgName", "ImgUrl", "IsHot", "IsInstock", "IsItemOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("9e8807be-f6d9-4ec5-926f-bc61f59e0151"), 98, new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "Brown", "Sat, 28 May 2022 00:09:42 GMT", 0.9m, "29.jpg", "https://localhost:5001/img/29.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Brown Smart Watch", 569.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("72d54e6d-6f15-45ca-9f50-756f64abed77"), 378, new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "Silver", "Sat, 28 May 2022 00:09:42 GMT", 0.9m, "30.jpg", "https://localhost:5001/img/30.jpg", false, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "AZ Pentom Laptop", 2499.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("1806e1e6-f3ac-4c16-86ce-842355bcf971"), 198, new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "White", "Sat, 28 May 2022 00:09:42 GMT", 0.3m, "31.jpg", "https://localhost:5001/img/31.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "White Smart Watch", 899.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("6c38829d-dea7-4cd0-9bbc-54456a7f9d8e"), 38, new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "Gray", "Sat, 28 May 2022 00:09:42 GMT", 0m, "32.jpg", "https://localhost:5001/img/32.jpg", true, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Slick Design Dake PC Laptop", 2999.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("c8ef4c35-afa3-4ecc-bd7d-e633fbc70fa7"), 388, new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"), "Gray", "Sat, 28 May 2022 00:09:42 GMT", 0m, "33.jpg", "https://localhost:5001/img/33.jpg", false, true, true, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "GLK 300 Android Phone", 999.99m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e6f226d-045f-42f0-9938-90fc167ff379");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "94ae6d62-c563-42d0-906b-a45c7b8966eb");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("01ca406b-4a58-4fa5-b8c4-2fae4d0dc5c5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("06c43706-c835-425d-8db6-893f5857e927"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0922c952-8fc6-4ac3-8e39-7c4ffd6bd08d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0bbf2fa3-f001-4fa9-8009-0ed5320a7956"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1806e1e6-f3ac-4c16-86ce-842355bcf971"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("35086945-8527-4ee9-8f40-f267928563d0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3b13a409-4421-4ddc-90dd-82387d2f254b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4326175e-654c-4b59-8639-cce104098fd3"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("43795276-ba28-4b0a-8b50-ad8fbf71e4ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5568b375-5296-41cb-8da8-71f952644132"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("58e507b9-0598-4b27-937a-90e15e4fd297"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("5c92ad2f-06c1-40c2-8c7e-43385d3a37af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6094ed7d-2642-4c71-b72c-260af4a9b059"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("682c2f5b-7ae4-49fb-9d8f-adf222302174"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c38829d-dea7-4cd0-9bbc-54456a7f9d8e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6c8040ce-4e5c-452e-b476-e046cbcf0489"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72d54e6d-6f15-45ca-9f50-756f64abed77"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72f9bac4-136e-4a64-815d-e4361517830d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("767bb381-f535-4d43-b87d-b97730b53a4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b30f49b-d015-43cd-833f-d52f46bc4175"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b7eb870-4168-46a5-8c8e-8d77a631c2b9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8a28435a-f452-4f5a-a37f-bd446e263ded"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9e8807be-f6d9-4ec5-926f-bc61f59e0151"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad74ac6e-1ba0-4931-a065-12c761d1601b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("afacfdc4-302a-470e-bbe5-c6c28147a50c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b83d25dd-1340-4e03-b9b7-12ed2bcfb328"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c8ef4c35-afa3-4ecc-bd7d-e633fbc70fa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cd48196a-c4ab-44ce-8ef6-21e67bedc7a4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d3aff2f8-4951-4a5c-a382-d417365dfb1d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e19f9012-2dab-4627-b1d4-abeacf4f02f7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e37d247b-6b79-49da-a1ca-1c3679d2f9af"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ea9c0fd4-b526-4661-a602-d78616322673"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ed6da7cb-f541-478e-954e-e04625a17165"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("efb817a1-eb23-4c5f-864a-400652d68c49"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f5a1bba2-b431-44d2-9aab-1c99b98cff7c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f79e4a2b-e664-4cd1-a3c2-f6245c43efed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2868642b-8c0a-44ec-00fd-43d9c009e126"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "82659aa3-4b78-477b-9cd1-d03e2cc4f7b1", "b38bfa04-3fd9-49a0-8f67-0a4002831669", "Administrator", "ADMINISTRATOR" },
                    { "7f41c946-b546-45fe-8ad0-6e8575a4c5f9", "aa624519-7212-42ee-8ace-fbb18e66965e", "User", "USER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0bbc8cb9-cc68-4c16-90fc-08d9c009e093"),
                columns: new[] { "Description", "Name" },
                values: new object[] { "Fashion and Designer watches", "Watches" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("357fb7c4-b49a-4b78-90fe-08d9c009e093"),
                column: "Description",
                value: "Fine bracelets for men");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa920d5c-d44e-4d5c-90ff-08d9c009e093"),
                column: "Description",
                value: "Bracelets for sports");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"),
                column: "Description",
                value: "Fashion and Designer bracelets for women");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AmountAvailable", "CategoryId", "Color", "DateCreated", "Discount", "ImgName", "ImgUrl", "IsHot", "IsInstock", "IsItemOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { new Guid("63feb0db-b5ec-47af-8bae-0a491e33745e"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/5.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("6a671375-5c8b-447e-8b41-97f0742ba671"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/1.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("85f8d933-14b5-43a5-8151-451d5bd2bf91"), 76, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/2.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("3424d726-9737-46b3-af70-79e07da5f592"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/30.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("91e620ea-7ce0-49ed-9470-a40a7887ade2"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/29.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
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
                    { new Guid("be27e401-656a-46a8-bf19-558642a87615"), 34, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/3.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
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
                    { new Guid("c1c78615-1559-4232-9dc3-dbcd6b33bbfe"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/4.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" },
                    { new Guid("b6cf0e5a-9e1e-4324-9487-04334ee5d976"), 108, new Guid("e931604b-8cba-41ec-90fd-08d9c009e093"), "Pink", "Sun, 22 May 2022 17:31:57 GMT", 0.1m, "1.jpg", "https://localhost:5001/img/16.jpg", true, true, false, "Lorem ipsum dolor sit amet consectetur adipisicing elit. Sunt vero, sit saepe temporibus veritatis quod tempore qui at maxime hic animi ipsa illum dolor optio suscipit quas aliquam ab repudiandae. Incidunt exercitationem minima illum autem officiis suscipit quo esse perferendis consectetur ipsa. Perspiciatis exercitationem a eos sit, qui id veritatis!", "Sk Duoyo Bracelet", 56.00m, "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Amet dignissimos veniam id recusandae nemo? Nostrum?" }
                });
        }
    }
}
