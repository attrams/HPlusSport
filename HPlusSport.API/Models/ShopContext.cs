using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models;

public class ShopContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public ShopContext(DbContextOptions<ShopContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(category => category.Products)
            .WithOne(product => product.Category)
            .HasForeignKey(product => product.CategoryId);

        modelBuilder.Seed();
    }
}