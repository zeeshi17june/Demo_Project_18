using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ODCWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _16_dec_1234 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Floors",
                newName: "FloorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FloorId",
                table: "Floors",
                newName: "Id");
        }
    }
}
