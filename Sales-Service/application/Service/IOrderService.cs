using Sales_Service.domain.Entity;
using System.Collections.Generic;

namespace Sales_Service.application.Service;

public interface IOrderService
{
    List<DomainOrderEntity> GetAllOrders();
    DomainOrderEntity GetOrderById(Guid id);
    DomainOrderEntity CreateOrder(DomainOrderEntity order);
}

