using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RolesAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5817c62b-2ef8-41a5-ae6c-1e9d842996b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2a6007c-22b2-4c0d-a1f5-d101799e5cb8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1bf14b9b-63bd-4bb7-8713-d773c9399610", null, "Admin", "ADMIN" },
                    { "78e06984-9a5d-4999-861c-82ab79467479", null, "Customer", "CUSTOMER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bf14b9b-63bd-4bb7-8713-d773c9399610");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78e06984-9a5d-4999-861c-82ab79467479");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5817c62b-2ef8-41a5-ae6c-1e9d842996b8", null, "Customer", "CUSTOMER" },
                    { "b2a6007c-22b2-4c0d-a1f5-d101799e5cb8", null, "Admin", "ADMIN" }
                });
        }
    }
}
