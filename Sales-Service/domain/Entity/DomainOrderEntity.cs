namespace Sales_Service.domain.Entity;


/*
public class DomainOrderEntity
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public int IdUser { get; set; }
}*/


using System;

public class DomainOrderEntity
{
    public Guid OrderId { get; set; }
    public Guid BuyerId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalAmount { get; set; }
    public OrderPaymentStatus PaymentStatus { get; set; } = OrderPaymentStatus.PENDING;
    public EscrowStatus EscrowStatus { get; set; } = EscrowStatus.PENDING;
    public int Version { get; set; } = 1;
}