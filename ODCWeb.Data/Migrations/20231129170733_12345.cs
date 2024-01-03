using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ODCWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _12345 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 8);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Floors",
                columns: new[] { "FloorId", "Name" },
                values: new object[,]
                {
                    { 1, "Basement" },
                    { 2, "First Floor" },
                    { 3, "Second Floor" },
                    { 4, "Third Floor" },
                    { 5, "Forth Floor" },
                    { 6, "Fifth Floor" },
                    { 7, "Sixth Floor" },
                    { 8, "Eighth Floor" }
                });
        }
    }
}
