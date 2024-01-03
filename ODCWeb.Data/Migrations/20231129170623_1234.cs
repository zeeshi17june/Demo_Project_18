using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ODCWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 8,
                column: "Name",
                value: "Eighth Floor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 8,
                column: "Name",
                value: "Eigth Floor");
        }
    }
}
