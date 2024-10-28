using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PerfumeShop.Models.Entities;

namespace PerfumeShop.Areas.Identity.Data;

public class PerfumeShopContext : IdentityDbContext<User>
{
    public PerfumeShopContext(DbContextOptions<PerfumeShopContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<Order>()
                 .Property(e => e.OrderDate)
                 .HasDefaultValueSql("CURRENT_TIMESTAMP");
    }
}
