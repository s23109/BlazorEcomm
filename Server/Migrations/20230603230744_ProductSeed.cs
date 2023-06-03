using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    public partial class ProductSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Pan Tadeusz, czyli ostatni zajazd na Litwie – poemat epicki Adama Mickiewicza wydany w dwóch tomach w 1834 w Paryżu przez Aleksandra Jełowickiego.", "https://upload.wikimedia.org/wikipedia/commons/c/cb/Pan_Tadeusz_1834.jpeg", 6.99m, "Pan Tadeusz" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Balladyna – dramat romantyczny w pięciu aktach, napisany przez Juliusza Słowackiego w Genewie w 1834 roku, a wydany w Paryżu w roku 1839.", "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg/260px-Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg", 7.99m, "Balladyna" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Ogniem i mieczem – pierwsza z trzech powieści historycznych będących częścią Trylogii, pisanej dla pokrzepienia serc przez Henryka Sienkiewicza w latach 1884–1888.", "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg/230px-Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg", 8.99m, "Ogniem i mieczem" });
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

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
