
using Sales_Service.adapter.restful.v1.controller.Entity;
using Sales_Service.domain.Entity;


namespace Sales_Service.adapter.restful.v1.controller.Mapper;

public class AdapterMapper : IAdapterMapper
{
    public AdapterOrderEntity ToAdapterOrder(DomainOrderEntity domainOrder)
    {
        if (domainOrder == null) throw new ArgumentNullException(nameof(domainOrder));
        return new AdapterOrderEntity
        {
            Id = domainOrder.Id,
            OrderDate = domainOrder.OrderDate,
            Total = domainOrder.Total,
            IdUser = domainOrder.IdUser
        };
    }

    public List<AdapterOrderEntity> ToAdapterOrderList(List<DomainOrderEntity> domainOrders)
    {
        var list = new List<AdapterOrderEntity>();
        if (domainOrders == null) return list;
        foreach (var d in domainOrders)
        {
            list.Add(ToAdapterOrder(d));
        }
        return list;
    }

    public DomainOrderEntity ToDomainOrder(AdapterOrderEntity adapterOrder)
    {
        if (adapterOrder == null) throw new ArgumentNullException(nameof(adapterOrder));
        return new DomainOrderEntity
        {
            Id = adapterOrder.Id,
            OrderDate = adapterOrder.OrderDate,
            Total = adapterOrder.Total,
            IdUser = adapterOrder.IdUser
        };
    }
}

