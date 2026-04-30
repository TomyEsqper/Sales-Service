namespace Sales_Service.adapter.restful.v1.controller.Mapper;

using Sales_Service.adapter.restful.v1.controller.Entity;
using Sales_Service.domain.Entity;
using System.Collections.Generic;

public interface IAdapterMapper
{
    AdapterOrderEntity ToAdapterOrder(DomainOrderEntity domainOrder);
    List<AdapterOrderEntity> ToAdapterOrderList(List<DomainOrderEntity> domainOrders);
    DomainOrderEntity ToDomainOrder(AdapterOrderEntity adapterOrder);
}

