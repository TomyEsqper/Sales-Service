using Microsoft.EntityFrameworkCore;
using Sales_Service.infrastructure.Entity;

namespace Sales_Service.infrastructure.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<OrderEntity> Orders { get; set; } = null!;
}

