using System.ComponentModel.DataAnnotations;
using Sales_Service.domain.Entity;

namespace Sales_Service.infrastructure.Entity;


public class DeliveryEntity
{
    [Key]
    public string DeliveryId { get; set; } = string.Empty;
    public string OrderId { get; set; } = string.Empty;
    public DeliveryMethod DeliveryMethod { get; set; }
    public  string? DeliveryAddress { get; set; }
    public string? TrackingCode { get; set; }
    public DeliveryStatus DeliveryStatus { get; set; }
    public DateTime? DeliveredAt { get; set; }
    public DateTime? WarrantyExpirationDate { get; set; }
}