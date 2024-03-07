using Microsoft.EntityFrameworkCore;

namespace StoreApp.Data.Concrete;

public class StoreDbContext : DbContext
{
    public StoreDbContext(DbContextOptions<StoreDbContext> options) : base (options)
    {

    }

    public DbSet<Product> Products => Set<Product>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Product>().HasData(
            new List<Product>() {
                new() {
                    Id = 1,
                    Name = "Samsung S24",
                    Description = "Güzel bir telefon",
                    Price = 50000,
                    Category = "Telefon"
                },
                new() {
                    Id = 2,
                    Name = "Samsung S25",
                    Description = "Güzel bir telefon",
                    Price = 55000,
                    Category = "Telefon"
                },
                new() {
                    Id = 3,
                    Name = "Samsung S26",
                    Description = "Güzel bir telefon",
                    Price = 60000,
                    Category = "Telefon"
                },
                new() {
                    Id = 4,
                    Name = "Samsung S27",
                    Description = "Güzel bir telefon",
                    Price = 64000,
                    Category = "Telefon"
                },
                new() {
                    Id = 5,
                    Name = "Samsung S28",
                    Description = "Güzel bir telefon",
                    Price = 70000,
                    Category = "Telefon"
                },
                new() {
                    Id = 6,
                    Name = "Samsung S29",
                    Description = "Güzel bir telefon",
                    Price = 85000,
                    Category = "Telefon"
                },
            }
        );
    }
}