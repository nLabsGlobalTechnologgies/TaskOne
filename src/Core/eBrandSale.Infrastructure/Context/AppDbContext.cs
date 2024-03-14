using eBrandSale.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eBrandSale.Infrastructure.Context;
internal sealed class AppDbContext : IdentityDbContext<AppUser, IdentityRole, string>
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    //public DbSet<Brand>? Brands { get; set; }
    //public DbSet<Product>? Products { get; set; }
    //public DbSet<ProductDetail>? ProductDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
