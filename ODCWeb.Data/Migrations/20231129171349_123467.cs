using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ODCWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _123467 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ODCProjectId",
                table: "Floors",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 1,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 2,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 3,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 4,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 5,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 6,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 7,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Floors",
                keyColumn: "FloorId",
                keyValue: 8,
                column: "ODCProjectId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Floors_ODCProjectId",
                table: "Floors",
                column: "ODCProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Floors_Projects_ODCProjectId",
                table: "Floors",
                column: "ODCProjectId",
                principalTable: "Projects",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Floors_Projects_ODCProjectId",
                table: "Floors");

            migrationBuilder.DropIndex(
                name: "IX_Floors_ODCProjectId",
                table: "Floors");

            migrationBuilder.DropColumn(
                name: "ODCProjectId",
                table: "Floors");
        }
    }
}
