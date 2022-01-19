using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcell.Server.Migrations
{
    public partial class stuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Product_id",
                table: "WishListItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wishlist_id",
                table: "WishListItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Product_id",
                table: "WishListItems");

            migrationBuilder.DropColumn(
                name: "Wishlist_id",
                table: "WishListItems");
        }
    }
}
