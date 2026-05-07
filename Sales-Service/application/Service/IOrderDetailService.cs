using Sales_Service.domain.Entity;

namespace Sales_Service.application.Service;

public interface IOrderDetailsService
{
    // Obtener un detalle de orden por su ID
    DomainOrderDetailEntity GetOrderDetailById(int id);
    
    // Obtener todos los detalles de una orden específica
    List<DomainOrderDetailEntity> GetOrderDetailsByOrderId(Guid orderId);
}