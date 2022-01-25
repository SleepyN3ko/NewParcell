using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcell.Server.Migrations
{
    public partial class removedRedundentData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "P_username",
                table: "Swaps");

            migrationBuilder.DropColumn(
                name: "S_username",
                table: "Swaps");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "P_username",
                table: "Swaps",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "S_username",
                table: "Swaps",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
