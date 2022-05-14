using Microsoft.EntityFrameworkCore.Migrations;

namespace SKShopAPI.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53f1b432-b13c-40c9-85a7-8bfeab1fdc6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8bb4d64-3ba5-48af-95a5-73b6bac2c67a");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9bdc471-5a8b-4a3c-97df-f83b39b34345", "18460bb1-3009-4906-a3df-6f78b023e907", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e02dee51-2eb1-4a64-b635-8ecb8db56d50", "c94b6352-f495-4e42-8016-c6bc37aa45b7", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bdc471-5a8b-4a3c-97df-f83b39b34345");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e02dee51-2eb1-4a64-b635-8ecb8db56d50");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53f1b432-b13c-40c9-85a7-8bfeab1fdc6c", "1ff8822f-96c6-4975-ac20-77ca12aea9d1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f8bb4d64-3ba5-48af-95a5-73b6bac2c67a", "467815f4-29c2-4840-8b8a-2340d048005a", "User", "USER" });
        }
    }
}
