using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcell.Server.Migrations
{
    public partial class addedquanitytoswap : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PProduct_quantity",
                table: "Swaps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SProduct_quantity",
                table: "Swaps",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PProduct_quantity",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "SProduct_quantity",
                table: "Swaps");
        }
    }
}
