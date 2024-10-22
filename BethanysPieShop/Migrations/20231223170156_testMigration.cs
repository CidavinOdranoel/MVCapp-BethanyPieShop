using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BethanysPieShop.Migrations
{
    /// <inheritdoc />
    public partial class testMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCardId",
                table: "ShoppingCardItems",
                newName: "ShoppingCartId");

            migrationBuilder.RenameColumn(
                name: "ShoppingCardItemId",
                table: "ShoppingCardItems",
                newName: "ShoppingCartItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingCartId",
                table: "ShoppingCardItems",
                newName: "ShoppingCardId");

            migrationBuilder.RenameColumn(
                name: "ShoppingCartItemId",
                table: "ShoppingCardItems",
                newName: "ShoppingCardItemId");
        }
    }
}
