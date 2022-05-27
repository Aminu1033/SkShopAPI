using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SKShopAPI.Migrations
{
    public partial class user_and_product_entity_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128e9cbf-3ea6-4428-9c54-f19074eaf701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20a24ade-05f1-4716-8cbd-b4874fdb6c94");

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "Products",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgName",
                table: "AspNetUsers",
                type: "varchar(250)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImgName",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20a24ade-05f1-4716-8cbd-b4874fdb6c94", "11a6efd1-f142-4608-b193-57b4bc8edf35", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "128e9cbf-3ea6-4428-9c54-f19074eaf701", "8816c6a6-80da-4114-8427-43112d1deab7", "User", "USER" });
        }
    }
}
