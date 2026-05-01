using System;
using Sales_Service.domain.Entity;

namespace Sales_Service.adapter.restful.v1.controller.Entity;

public class AdapterOrderEntity
{
    public Guid OrderId { get; set; }
    public Guid BuyerId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public OrderPaymentStatus PaymentStatus { get; set; }
    public EscrowStatus EscrowStatus { get; set; }
    public int Version { get; set; }
}

