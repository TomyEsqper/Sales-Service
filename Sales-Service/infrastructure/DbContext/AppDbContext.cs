using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sales_Service.infrastructure.Entity;
using Sales_Service.domain.Entity;

namespace Sales_Service.infrastructure.DbContext;

public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<OrderEntity> Orders { get; set; } = null!;
    public DbSet<PaymentEntity> Payments { get; set; } = null!;
    public DbSet<DeliveryEntity> Deliveries { get; set; } = null!;
    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Traductores de Enums (Ignoran mayúsculas/minúsculas para evitar errores)
        var paymentStatusConverter = new ValueConverter<PaymentStatus, string>(
            v => v.ToString(),
            v => (PaymentStatus)Enum.Parse(typeof(PaymentStatus), v, true));

        var deliveryMethodConverter = new ValueConverter<DeliveryMethod, string>(
            v => v.ToString(),
            v => (DeliveryMethod)Enum.Parse(typeof(DeliveryMethod), v, true));

        var deliveryStatusConverter = new ValueConverter<DeliveryStatus, string>(
            v => v.ToString(),
            v => (DeliveryStatus)Enum.Parse(typeof(DeliveryStatus), v, true));

        // Aplicar conversores a Payments
        modelBuilder.Entity<PaymentEntity>()
            .Property(p => p.Status)
            .HasConversion(paymentStatusConverter);

        // Aplicar conversores a Deliveries
        modelBuilder.Entity<DeliveryEntity>()
            .Property(d => d.DeliveryMethod)
            .HasConversion(deliveryMethodConverter);

        modelBuilder.Entity<DeliveryEntity>()
            .Property(d => d.DeliveryStatus)
            .HasConversion(deliveryStatusConverter);
    }
}

