namespace Sales_Service.domain.Entity;

public class DomainDeliveryEntity
{
    public string DeliveryId { get; set; }
    public string OrderId { get; set; } = string.Empty;
    public DeliveryMethod DeliveryMethod { get; set; }
    public string? DeliveryAddress { get; set; }
    public string? TrackingCode { get; set; }
    public DeliveryStatus DeliveryStatus { get; set; } = DeliveryStatus.PENDING;
    public DateTime? DeliveredAt { get; set; }
    public DateTime? WarrantyExpirationDate { get; set; }
}