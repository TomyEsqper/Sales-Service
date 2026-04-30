namespace Sales_Service.adapter.restful.v1.controller.Entity;

public class AdapterOrderEntity
{
    public int Id { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Total { get; set; }
    public int IdUser { get; set; }
}

