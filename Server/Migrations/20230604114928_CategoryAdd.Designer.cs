﻿// <auto-generated />
using BlazorEcomm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcomm.Server.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230604114928_CategoryAdd")]
    partial class CategoryAdd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorEcomm.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Books",
                            Url = "books"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Movies",
                            Url = "movies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Video Games",
                            Url = "video-games"
                        });
                });

            modelBuilder.Entity("BlazorEcomm.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Pan Tadeusz, czyli ostatni zajazd na Litwie – poemat epicki Adama Mickiewicza wydany w dwóch tomach w 1834 w Paryżu przez Aleksandra Jełowickiego.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/c/cb/Pan_Tadeusz_1834.jpeg",
                            Price = 6.99m,
                            Title = "Pan Tadeusz"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Balladyna – dramat romantyczny w pięciu aktach, napisany przez Juliusza Słowackiego w Genewie w 1834 roku, a wydany w Paryżu w roku 1839.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/1f/Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg/260px-Juliusz_S%C5%82owacki_Balladyna_r%C4%99kopis_%28cropped%29.jpg",
                            Price = 7.99m,
                            Title = "Balladyna"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Ogniem i mieczem – pierwsza z trzech powieści historycznych będących częścią Trylogii, pisanej dla pokrzepienia serc przez Henryka Sienkiewicza w latach 1884–1888.",
                            ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/71/Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg/230px-Ogniem_I_Mieczem_%281885%29_%28title_page%29.jpg",
                            Price = 8.99m,
                            Title = "Ogniem i mieczem"
                        });
                });

            modelBuilder.Entity("BlazorEcomm.Shared.Product", b =>
                {
                    b.HasOne("BlazorEcomm.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
