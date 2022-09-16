using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelListing.API.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84f39531-e747-4789-a6e3-554f77871431");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d5841e9-172b-4ce7-96d3-ca71fdf316be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "56f4b4c7-41d7-4a58-bc72-25902a0ca0cb", "a366b3ff-469f-403e-80e5-d09df95fd248", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d074fc2d-862e-44a9-a245-5ee8531f0b8d", "5f6027f5-6e4a-4887-9700-12005928c970", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56f4b4c7-41d7-4a58-bc72-25902a0ca0cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d074fc2d-862e-44a9-a245-5ee8531f0b8d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "84f39531-e747-4789-a6e3-554f77871431", "24715660-0b4f-4a05-b690-c4cbb2ddca79", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9d5841e9-172b-4ce7-96d3-ca71fdf316be", "fca83d6a-8ed1-4a99-8d2f-35e837473fa6", "Administrator", "ADMINISTRATOR" });
        }
    }
}
