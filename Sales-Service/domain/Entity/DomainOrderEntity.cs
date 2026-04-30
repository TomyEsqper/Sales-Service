namespace Sales_Service.domain.Entity;

public class DomainOrderEntity
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public int IdUser { get; set; }
}
