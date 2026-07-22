using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SIDS.DataAccess.Models;

namespace SIDS.DataAccess.DbContexts;

public class AppDbContext : DbContext
{
    public DbSet<Page> Pages { get; set; }
    public DbSet<Keyword> Keywords { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Page>(entity =>
        {
            entity.ToTable("Pages");

            entity.HasKey(x => x.Id);

            entity.Property(x => x.Title)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(500);

            entity.Property(x => x.Description)
                .HasColumnType("longtext");

            entity.HasMany(p => p.Keywords)
                .WithMany(k => k.Pages)
                .UsingEntity(j => j.ToTable("PageKeywords"));
        });

        modelBuilder.Entity<Keyword>(entity =>
        {
            entity.ToTable("Keywords");

            entity.HasKey(x => x.Id);

            entity.Property(x => x.Word)
                .IsRequired()
                .HasMaxLength(100);

            entity.HasIndex(x => x.Word).IsUnique();
        });


        modelBuilder.Entity<Page>().HasData(
            new Page
            {
                Id = 1,
                Title = "Главная",
                Url = "/",
                Description = "Добро пожаловать на сайт"
            },
            new Page
            {
                Id = 2,
                Title = "Объект-1 RU —«Предсказатель»",
                Url = "Anomalies/1",
                Description = "Сновидец"
            },
            new Page
            {
                Id = 3,
                Title = "О нас",
                Url = "Anomalies/2",
                Description = "Информация о компании"
            }
        );

        modelBuilder.Entity<Keyword>().HasData(
            new Keyword { Id = 1, Word = "55" },
            new Keyword { Id = 2, Word = "зона" },
            new Keyword { Id = 3, Word = "ry" },
            new Keyword { Id = 4, Word = "предсказатель" },
            new Keyword { Id = 5, Word = "малоопасный" },
            new Keyword { Id = 6, Word = "объект" },
            new Keyword { Id = 7, Word = "34" },
            new Keyword { Id = 8, Word = "лунные дети" },
            new Keyword { Id = 9, Word = "культ" },
            new Keyword { Id = 10, Word = "нейропсихология" },
            new Keyword { Id = 11, Word = "uz" },
            new Keyword { Id = 12, Word = "2" },
            new Keyword { Id = 13, Word = "pl" },
            new Keyword { Id = 14, Word = "3" },
            new Keyword { Id = 15, Word = "4" },
            new Keyword { Id = 16, Word = "uk" },
            new Keyword { Id = 17, Word = "5" },
            new Keyword { Id = 18, Word = "6" },
            new Keyword { Id = 19, Word = "ar" },
            new Keyword { Id = 20, Word = "7" },
            new Keyword { Id = 21, Word = "tr" },
            new Keyword { Id = 22, Word = "8" },
            new Keyword { Id = 23, Word = "9" },
            new Keyword { Id = 24, Word = "mn" },
            new Keyword { Id = 25, Word = "10" },
            new Keyword { Id = 26, Word = "11" },
            new Keyword { Id = 27, Word = "12" },
            new Keyword { Id = 28, Word = "tr" },
            new Keyword { Id = 29, Word = "13" },
            new Keyword { Id = 30, Word = "14" },
            new Keyword { Id = 31, Word = "eg" },
            new Keyword { Id = 32, Word = "15" },
            new Keyword { Id = 33, Word = "de" },
            new Keyword { Id = 34, Word = "16" },
            new Keyword { Id = 35, Word = "fr" },
            new Keyword { Id = 36, Word = "17" },
            new Keyword { Id = 37, Word = "ca" },
            new Keyword { Id = 38, Word = "18" },
            new Keyword { Id = 39, Word = "49" },
            new Keyword { Id = 40, Word = "gl" },
            new Keyword { Id = 41, Word = "67" },
             new Keyword { Id = 42, Word = "us" },
            new Keyword { Id = 43, Word = "100" },
            new Keyword { Id = 44, Word = "cn" },
            new Keyword { Id = 45, Word = "123" },
            new Keyword { Id = 46, Word = "kr" },
            new Keyword { Id = 47, Word = "155" },
            new Keyword { Id = 48, Word = "234" },
            new Keyword { Id = 49, Word = "kz" },
            new Keyword { Id = 50, Word = "327" },
            new Keyword { Id = 51, Word = "457" },
            new Keyword { Id = 52, Word = "ph" },
            new Keyword { Id = 53, Word = "500" },
            new Keyword { Id = 54, Word = "br" },
            new Keyword { Id = 55, Word = "533" },
            new Keyword { Id = 56, Word = "lp" },
            new Keyword { Id = 57, Word = "666" },
            new Keyword { Id = 58, Word = "mx" },
            new Keyword { Id = 59, Word = "784" },
            new Keyword { Id = 60, Word = "world" },
            new Keyword { Id = 61, Word = "890" },
            new Keyword { Id = 62, Word = "in" },
            new Keyword { Id = 63, Word = "895" },
            new Keyword { Id = 64, Word = "923" },
            new Keyword { Id = 65, Word = "990" },
            new Keyword { Id = 66, Word = "fi" },
            new Keyword { Id = 67, Word = "1126" },
            new Keyword { Id = 68, Word = "1917" },
            new Keyword { Id = 69, Word = "2023" },
            new Keyword { Id = 70, Word = "es" },
            new Keyword { Id = 71, Word = "2941" },
            new Keyword { Id = 72, Word = "4579" },
            new Keyword { Id = 73, Word = "сейсмоактивность" },
            new Keyword { Id = 74, Word = "меметический" }
        );


        modelBuilder.Entity("PageKeywords").HasData(
            new { PagesId = 1, KeywordsId = 1 },
            new { PagesId = 1, KeywordsId = 2 },

            new { PagesId = 2, KeywordsId = 1 },
            new { PagesId = 2, KeywordsId = 2 },
            new { PagesId = 2, KeywordsId = 7 },
            new { PagesId = 2, KeywordsId = 11 },
            new { PagesId = 2, KeywordsId = 6 },
            new { PagesId = 2, KeywordsId = 5 },
            new { PagesId = 2, KeywordsId = 8 },
            new { PagesId = 2, KeywordsId = 9 },
            new { PagesId = 2, KeywordsId = 10 },
            new { PagesId = 2, KeywordsId = 73 },
            new { PagesId = 2, KeywordsId = 74 },


            new { PagesId = 3, KeywordsId = 2 },
            new { PagesId = 3, KeywordsId = 1 },
            new { PagesId = 3, KeywordsId = 6 },
            new { PagesId = 3, KeywordsId = 5 }
        );
    }
}


public class AppDbContextFactory
    : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        string basePath = Directory.GetCurrentDirectory();

        IConfiguration config = new ConfigurationBuilder()
            .SetBasePath(basePath)
            .AddJsonFile("appsettings.json")
            .Build();

        string connectionString =
            config.GetConnectionString("DefaultConnection");

        var optionsBuilder =
            new DbContextOptionsBuilder<AppDbContext>();

        optionsBuilder.UseMySql(
            connectionString,
            ServerVersion.AutoDetect(connectionString)
        );

        return new AppDbContext(optionsBuilder.Options);
    }
}