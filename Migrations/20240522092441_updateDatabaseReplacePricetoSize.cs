using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompStore.Migrations
{
    /// <inheritdoc />
    public partial class updateDatabaseReplacePricetoSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Computers");

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Details",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Computers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "Details");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Computers");

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Details",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Computers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
