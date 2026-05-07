namespace Sales_Service.infrastructure.Entity;

public class OrderDetailEntity
{
    public int OrderDetailId { get; set; }
    public Guid OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPriceAtSale { get; set; }
    public decimal SnapShotTax { get; set; }
    public decimal CommissionAmount { get; set; }
    public decimal SubTotal { get; set; }
}