using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.Entity;
using System.Collections.Generic;

namespace Sales_Service.infrastructure.Mapper;

public interface IInfrastructureMapper
{
    OrderEntity ToInfrastructureOrder(DomainOrderEntity domainOrder);
    List<OrderEntity> ToInfrastructureOrderList(List<DomainOrderEntity> domainOrders);
    DomainOrderEntity ToDomainOrder(OrderEntity orderEntity);
    
    PaymentEntity ToInfrastructurePayment(DomainPaymentEntity domainPayment);
    DomainPaymentEntity ToDomainPayment(PaymentEntity paymentEntity);
    
    DomainOrderDetailEntity ToDomainOrderDetail(OrderDetailEntity entity);
}


