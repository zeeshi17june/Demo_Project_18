using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ODCWeb.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class _15dec2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Projects");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "EndDate",
                table: "Projects",
                type: "date",
                nullable: true);
        }
    }
}
