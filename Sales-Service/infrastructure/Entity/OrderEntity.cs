namespace Sales_Service.infrastructure.Entity;

public class OrderEntity
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public int IdUser { get; set; }
}

