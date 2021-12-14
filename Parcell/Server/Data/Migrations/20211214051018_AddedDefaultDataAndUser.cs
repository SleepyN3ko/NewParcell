using Microsoft.EntityFrameworkCore.Migrations;

namespace Parcell.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "P_category", "Price", "Stock", "Swap_description", "Thumbnail", "UserId" },
                values: new object[] { 1, "Green water bottle that has totally not been used before", null, "Water Bottle", "Household", 100, 1, null, null, null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "P_category", "Price", "Stock", "Swap_description", "Thumbnail", "UserId" },
                values: new object[] { 2, "Green file that has nothing in it", null, "File", "Office", 10, 10, null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
