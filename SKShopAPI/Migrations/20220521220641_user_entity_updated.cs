using Microsoft.EntityFrameworkCore.Migrations;

namespace SKShopAPI.Migrations
{
    public partial class user_entity_updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bdc471-5a8b-4a3c-97df-f83b39b34345");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e02dee51-2eb1-4a64-b635-8ecb8db56d50");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "AspNetUsers",
                type: "varchar(250)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "20a24ade-05f1-4716-8cbd-b4874fdb6c94", "11a6efd1-f142-4608-b193-57b4bc8edf35", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "128e9cbf-3ea6-4428-9c54-f19074eaf701", "8816c6a6-80da-4114-8427-43112d1deab7", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "128e9cbf-3ea6-4428-9c54-f19074eaf701");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "20a24ade-05f1-4716-8cbd-b4874fdb6c94");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a9bdc471-5a8b-4a3c-97df-f83b39b34345", "18460bb1-3009-4906-a3df-6f78b023e907", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e02dee51-2eb1-4a64-b635-8ecb8db56d50", "c94b6352-f495-4e42-8016-c6bc37aa45b7", "User", "USER" });
        }
    }
}
