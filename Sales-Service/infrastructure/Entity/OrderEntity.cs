using System.ComponentModel.DataAnnotations;
using Sales_Service.domain.Entity;

namespace Sales_Service.infrastructure.Entity;

public class OrderEntity
{
    [Key]
    public Guid OrderId { get; set; }
    public Guid BuyerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; }
    public string EscrowStatus { get; set; }
    //public int Version { get; set; }
}

