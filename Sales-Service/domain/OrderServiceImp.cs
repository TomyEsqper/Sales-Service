using Sales_Service.application.Service;
using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.DbContext;
using System.Collections.Generic;

namespace Sales_Service.domain;

public class OrderServiceImp : IOrderService
{
    private readonly Repository _repository;

    public OrderServiceImp(Repository repository)
    {
        _repository = repository;
    }

    public List<DomainOrderEntity> GetAllOrders()
    {
        return _repository.GetAllOrders();
    }

    public DomainOrderEntity? GetOrderById(Guid id)
    {
        return _repository.GetOrderById(id);
    }

    public DomainOrderEntity CreateOrder(DomainOrderEntity order)
    {
        return _repository.CreateOrder(order);
    }
}

