namespace BlazorEcomm.Server.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Books",
                    Url = "books"
                },
                new Category
                {
                    Id = 2,
                    Name = "Movies",
                    Url = "movies"
                },
                new Category
                {
                    Id = 3,
                    Name = "Video Games",
                    Url = "video-games"
                }
                );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Title = "Pan Tadeusz",
                     Description = "Pan Tadeusz, czyli ostatni zajazd na Litwie – poemat epicki Adama Mickiewicza wydany w dwóch tomach w 1834 w Paryżu przez Aleksandra Jełowickiego.",
                     ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Pan_Tadeusz_1834.jpeg",
                     Price = 6.99m,
                     CategoryId=1
                 },
                new Product
                {
                    Id = 2,
                    Title = "Balladyna",
                    Description = "Balladyna – dramat romantyczny w pięciu aktach, napisany przez Juliusza Słowackiego w Genewie w 1834 roku, a wydany w Paryżu w roku 1839.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg/260px-Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg",
                    Price = 7.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 3,
                    Title = "Ogniem i mieczem",
                    Description = "Ogniem i mieczem – pierwsza z trzech powieści historycznych będących częścią Trylogii, pisanej dla pokrzepienia serc przez Henryka Sienkiewicza w latach 1884–1888.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg/230px-Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg",
                    Price = 8.99m,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 4,
                    Title = "Dzień świra",
                    Description = "Dzień świra – polski film fabularny z 2002 w reżyserii Marka Koterskiego, wyprodukowany przez Juliusza Machulskiego i Włodzimierza Otulaka. ",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fecsmedia.pl%2Fc%2Fdzien-swira-b-iext47665830.jpg&f=1&nofb=1&ipt=d3affeab3a853847cbad9883be4b20e8da81e69c039975c8ee064d74f5d2b461&ipo=images",
                    Price = 12.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 5,
                    Title = "Psy",
                    Description = "Psy – polski film kryminalny z 1992 w reżyserii i według scenariusza Władysława Pasikowskiego, wyprodukowany przez Juliusza Machulskiego. Jego polska premiera odbyła się 20 listopada 1992. Osią fabularną filmu jest konfrontacja dawnych przyjaciół, dwóch dawnych funkcjonariuszy Służby Bezpieczeństwa, Franza Maurera (Bogusław Linda) i Ola Żwirskiego (Marek Kondrat), z których pierwszy został przeniesiony do policji kryminalnej, drugi zaś przystąpił do mafii. Konflikt pomiędzy nimi wzmaga również wspólne uczucie do siedemnastoletniej Angeli (Agnieszka Jaskółka). ",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fm.media-amazon.com%2Fimages%2FM%2FMV5BZGQwODdkOTctYWRlNC00ZjcyLWE4ZjctODQxZGVlM2YyMzViXkEyXkFqcGdeQXVyMjMwOTA0Ng%40%40._V1_UY1200_CR101%2C0%2C630%2C1200_AL_.jpg&f=1&nofb=1&ipt=e9ea197af988d9db1208777beefdd043eafbd114f3f763916058c4c9e6a33b72&ipo=images",
                    Price = 15.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 6,
                    Title = "Kiler",
                    Description = "Kiler – polska komedia kryminalna w reżyserii Juliusza Machulskiego z 1997 roku na podstawie scenariusza Piotra Wereśniaka, wyprodukowana przez Studio Filmowe „Zebra”. ",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fs3.viva.pl%2Fnewsy%2Fplakat-filmu-kiler-466395-movie_cover.jpg&f=1&nofb=1&ipt=6b09f4561df69d2389c2333826247e9c5595bc2565f16c3e39b11cc09a1dd547&ipo=images",
                    Price = 13.99m,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "Counter-Strike",
                    Description = "Counter-Strike - gra komputerowa z gatunku first-person shooter, stworzona przez Minha \"Gooseman\" Le'a i Jessa \"Cliffe\" Cliffe'a 19 czerwca 1999[4] i będąca modyfikacją gry Half-Life. Początkowo Counter-Strike wymagał do działania Half-Life'a, jednak z upływem czasu stworzono kolejne wersje, które przekształciły się w samodzielne produkcje, korzystające jedynie z silnika oryginalnej gry. ",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fcdkeyprices.com%2Fimages%2Fgames%2F655691%2Fcover.jpg&f=1&nofb=1&ipt=d8c3685204f9047916059b18154938fcdf51890bc0e91f8559aeeb0c32315c64&ipo=images",
                    Price = 18.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 8,
                    Title = "Gothic",
                    Description = "Gothic – pierwsza część fabularnej gry akcji z serii Gothic wyprodukowana przez firmę Piranha Bytes i wydana przez Egmont Interactive w 2001 roku. Polskie wydanie oraz lokalizację (wraz z dubbingiem) zrealizowała firma CD Projekt.",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.giantbomb.com%2Fa%2Fuploads%2Foriginal%2F12%2F128291%2F1837152-gothic__cdcovers_cc__front.jpg&f=1&nofb=1&ipt=10e59e53606ed0c8786cddbab77e9171d196f7119552f4849d0cf058307224d1&ipo=images",
                    Price = 9.99m,
                    CategoryId = 3
                },
                new Product
                {
                    Id = 9,
                    Title = "The Elder Scrolls III: Morrowind",
                    Description = "The Elder Scrolls III: Morrowind – fabularna gra komputerowa wydana 1 maja 2002 roku na platformę Microsoft Windows i 6 czerwca 2002 roku na konsolę Xbox, trzecia część serii The Elder Scrolls. Rozgrywana może być z perspektywy pierwszej lub trzeciej osoby. 10 września 2004 roku zapowiedziana została następna część serii – The Elder Scrolls IV: Oblivion, która na rynku pojawiła się 20 marca 2006 roku.",
                    ImageUrl = "https://external-content.duckduckgo.com/iu/?u=http%3A%2F%2Fwww.mobygames.com%2Fimages%2Fcovers%2Fl%2F48979-the-elder-scrolls-iii-morrowind-windows-front-cover.jpg&f=1&nofb=1&ipt=f94a2e90faeb5fe933b60e40f5b97bc3ce23d658c46d5e1cea4b34b94501bff9&ipo=images",
                    Price = 5.99m,
                    CategoryId = 3
                }
                );

        }
    }
}
