using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    public partial class SeedProductWithCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 4, 2, "Dzień świra – polski film fabularny z 2002 w reżyserii Marka Koterskiego, wyprodukowany przez Juliusza Machulskiego i Włodzimierza Otulaka. ", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fecsmedia.pl%2Fc%2Fdzien-swira-b-iext47665830.jpg&f=1&nofb=1&ipt=d3affeab3a853847cbad9883be4b20e8da81e69c039975c8ee064d74f5d2b461&ipo=images", 12.99m, "Dzień świra" },
                    { 5, 2, "Psy – polski film kryminalny z 1992 w reżyserii i według scenariusza Władysława Pasikowskiego, wyprodukowany przez Juliusza Machulskiego. Jego polska premiera odbyła się 20 listopada 1992. Osią fabularną filmu jest konfrontacja dawnych przyjaciół, dwóch dawnych funkcjonariuszy Służby Bezpieczeństwa, Franza Maurera (Bogusław Linda) i Ola Żwirskiego (Marek Kondrat), z których pierwszy został przeniesiony do policji kryminalnej, drugi zaś przystąpił do mafii. Konflikt pomiędzy nimi wzmaga również wspólne uczucie do siedemnastoletniej Angeli (Agnieszka Jaskółka). ", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BZGQwODdkOTctYWRlNC00ZjcyLWE4ZjctODQxZGVlM2YyMzViXkEyXkFqcGdeQXVyMjMwOTA0Ng%40%40._V1_UY1200_CR101%2C0%2C630%2C1200_AL_.jpg&f=1&nofb=1&ipt=e9ea197af988d9db1208777beefdd043eafbd114f3f763916058c4c9e6a33b72&ipo=images", 15.99m, "Psy" },
                    { 6, 2, "Kiler – polska komedia kryminalna w reżyserii Juliusza Machulskiego z 1997 roku na podstawie scenariusza Piotra Wereśniaka, wyprodukowana przez Studio Filmowe „Zebra”. ", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fs3.viva.pl%2Fnewsy%2Fplakat-filmu-kiler-466395-movie_cover.jpg&f=1&nofb=1&ipt=6b09f4561df69d2389c2333826247e9c5595bc2565f16c3e39b11cc09a1dd547&ipo=images", 13.99m, "Kiler" },
                    { 7, 3, "Counter-Strike - gra komputerowa z gatunku first-person shooter, stworzona przez Minha \"Gooseman\" Le'a i Jessa \"Cliffe\" Cliffe'a 19 czerwca 1999[4] i będąca modyfikacją gry Half-Life. Początkowo Counter-Strike wymagał do działania Half-Life'a, jednak z upływem czasu stworzono kolejne wersje, które przekształciły się w samodzielne produkcje, korzystające jedynie z silnika oryginalnej gry. ", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdkeyprices.com%2Fimages%2Fgames%2F655691%2Fcover.jpg&f=1&nofb=1&ipt=d8c3685204f9047916059b18154938fcdf51890bc0e91f8559aeeb0c32315c64&ipo=images", 18.99m, "Counter-Strike" },
                    { 8, 3, "Gothic – pierwsza część fabularnej gry akcji z serii Gothic wyprodukowana przez firmę Piranha Bytes i wydana przez Egmont Interactive w 2001 roku. Polskie wydanie oraz lokalizację (wraz z dubbingiem) zrealizowała firma CD Projekt.", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.giantbomb.com%2Fa%2Fuploads%2Foriginal%2F12%2F128291%2F1837152-gothic__cdcovers_cc__front.jpg&f=1&nofb=1&ipt=10e59e53606ed0c8786cddbab77e9171d196f7119552f4849d0cf058307224d1&ipo=images", 9.99m, "Gothic" },
                    { 9, 3, "The Elder Scrolls III: Morrowind – fabularna gra komputerowa wydana 1 maja 2002 roku na platformę Microsoft Windows i 6 czerwca 2002 roku na konsolę Xbox, trzecia część serii The Elder Scrolls. Rozgrywana może być z perspektywy pierwszej lub trzeciej osoby. 10 września 2004 roku zapowiedziana została następna część serii – The Elder Scrolls IV: Oblivion, która na rynku pojawiła się 20 marca 2006 roku.", "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.mobygames.com%2Fimages%2Fcovers%2Fl%2F48979-the-elder-scrolls-iii-morrowind-windows-front-cover.jpg&f=1&nofb=1&ipt=f94a2e90faeb5fe933b60e40f5b97bc3ce23d658c46d5e1cea4b34b94501bff9&ipo=images", 5.99m, "The Elder Scrolls III: Morrowind" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
