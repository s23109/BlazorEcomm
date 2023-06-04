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
                }
                );

        }
    }
}
