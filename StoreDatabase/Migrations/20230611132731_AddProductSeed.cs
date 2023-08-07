using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StoreDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddProductSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "QuantityPerUnit", "UnitPrice", "UnitsInStock" },
                values: new object[,]
                {
                    { 1, "Screwdriver", null, 4.99f, 0 },
                    { 2, "Hammer", null, 6.99f, 0 },
                    { 3, "Drill", null, 59.99f, 0 },
                    { 4, "Circular Saw", null, 49.99f, 0 },
                    { 5, "Table Saw", null, 399.99f, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
