using System;
using System.ComponentModel.DataAnnotations;
using Sales_Service.domain.Entity;

namespace Sales_Service.infrastructure.Entity;

public class PaymentEntity
{
    [Key]
    public Guid PaymentId { get; set; }
    public Guid OrderId { get; set; }
    public string PaymentProvider { get; set; } = string.Empty;
    public string TransactionReference { get; set; } = string.Empty;
    public decimal AmountPaid { get; set; }
    public DateTime PaymentDate { get; set; }
    public PaymentStatus Status { get; set; }
}