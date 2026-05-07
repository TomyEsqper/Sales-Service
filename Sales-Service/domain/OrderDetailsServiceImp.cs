using System.Collections.Generic;
using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.DbContext;
using Sales_Service.application.Service;

namespace Sales_Service.domain;

public class OrderDetailsServiceImp : IOrderDetailsService
{
    private readonly Repository _repository;

    public OrderDetailsServiceImp(Repository repository)
    {
        _repository = repository;
    }

    public DomainOrderDetailEntity GetOrderDetailById(int id)
    {
        return _repository.GetOrderDetailById(id);
    }

    public List<DomainOrderDetailEntity> GetOrderDetailsByOrderId(Guid orderId)
    {
        return _repository.GetOrderDetailsByOrderId(orderId);
    }
}