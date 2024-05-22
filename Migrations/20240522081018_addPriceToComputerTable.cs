using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompStore.Migrations
{
    /// <inheritdoc />
    public partial class addPriceToComputerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Computers");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Computers",
                type: "decimal(9,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Computers");

            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Computers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
