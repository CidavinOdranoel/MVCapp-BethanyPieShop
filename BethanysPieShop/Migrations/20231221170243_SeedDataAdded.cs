using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BethanysPieShop.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Pies",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "pies", "Fruit pies" },
                    { 2, "cakes", "Cheese cakes" },
                    { 3, "pies", "Seasonal pies" }
                });

            migrationBuilder.InsertData(
                table: "Pies",
                columns: new[] { "PieId", "AllergyInformation", "CategoryId", "ImageThumnailUrl", "ImageUrl", "InStock", "IsPieOfTheWeek", "LongDescription", "Name", "Price", "ShortDescription" },
                values: new object[,]
                {
                    { 1, "", 1, "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png", "https://icons.iconarchive.com/icons/treetog/junior/128/folder-blue-pictures-icon.png", true, true, "Long Apple pie!!!", "Apple pie", 13, "Apple pie!" },
                    { 2, "", 2, "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png", "https://icons.iconarchive.com/icons/babasse/old-school/128/dossier-ardoise-images-icon.png", true, false, "Long Cheese cake!!!", "Cheese cake", 19, "Cheese cake!" },
                    { 3, "", 1, "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png", "https://icons.iconarchive.com/icons/gartoon-team/gartoon-mimetype/128/image-x-lws-icon.png", true, false, "Long Strawberry pie!!!", "Strawberry pie", 14, "Strawberry pie!" },
                    { 4, "", 3, "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png", "https://icons.iconarchive.com/icons/hopstarter/scrap/128/Picture-PNG-icon.png", true, true, "Long Seasonal pie!!!", "Seasonal pie", 14, "Seasonal pie!" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pies",
                keyColumn: "PieId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Pies",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
