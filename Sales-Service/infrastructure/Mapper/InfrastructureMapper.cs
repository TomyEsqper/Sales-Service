using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.Entity;
using System.Collections.Generic;
using Sales_Service.domain.Entity;
using Sales_Service.domain;

namespace Sales_Service.infrastructure.Mapper;

public class InfrastructureMapper : IInfrastructureMapper
{
    public OrderEntity ToInfrastructureOrder(DomainOrderEntity domainOrder)
    {
        if (domainOrder == null) return null!;

        return new OrderEntity
        {
            OrderId = domainOrder.OrderId,
            OrderDate = domainOrder.OrderDate,
            TotalAmount = domainOrder.TotalAmount,
            BuyerId = domainOrder.BuyerId,
            PaymentStatus = domainOrder.PaymentStatus.ToString(),
            EscrowStatus = domainOrder.EscrowStatus.ToString(),
          //  Version = domainOrder.Version
        };
    }

    public List<OrderEntity> ToInfrastructureOrderList(List<DomainOrderEntity> domainOrders)
    {
        var list = new List<OrderEntity>();
        if (domainOrders == null) return list;
        
        foreach (var d in domainOrders)
        {
            list.Add(ToInfrastructureOrder(d));
        }
        return list;
    }

    public DomainOrderEntity ToDomainOrder(OrderEntity orderEntity)
    {
        if (orderEntity == null) return null!;

        return new DomainOrderEntity
        {
            OrderId = orderEntity.OrderId,
            OrderDate = orderEntity.OrderDate,
            TotalAmount = orderEntity.TotalAmount,
            BuyerId = orderEntity.BuyerId,
            PaymentStatus = string.IsNullOrEmpty(orderEntity.PaymentStatus) 
                ? OrderPaymentStatus.PENDING 
                : Enum.Parse<OrderPaymentStatus>(orderEntity.PaymentStatus),
            EscrowStatus = string.IsNullOrEmpty(orderEntity.EscrowStatus)
                ? EscrowStatus.PENDING
                : Enum.Parse<EscrowStatus>(orderEntity.EscrowStatus),
        };
    }
    
    public PaymentEntity ToInfrastructurePayment(DomainPaymentEntity domain)
    {
        if (domain == null) return null!;
        return new PaymentEntity
        {
            PaymentId = domain.PaymentId,
            OrderId = domain.OrderId,
            PaymentProvider = domain.PaymentProvider,
            TransactionReference = domain.TransactionReference,
            AmountPaid = domain.AmountPaid,
            PaymentDate = domain.PaymentDate,
            Status = domain.Status
        };
    }

    public DomainPaymentEntity ToDomainPayment(PaymentEntity entity)
    {
        if (entity == null) return null!;
        return new DomainPaymentEntity
        {
            PaymentId = entity.PaymentId,
            OrderId = entity.OrderId,
            PaymentProvider = entity.PaymentProvider,
            TransactionReference = entity.TransactionReference,
            AmountPaid = entity.AmountPaid,
            PaymentDate = entity.PaymentDate,
            Status = entity.Status
        };
    }
    
    public DomainOrderDetailEntity ToDomainOrderDetail(OrderDetailEntity entity)
    {
        if (entity == null) return null!;
    
        return new DomainOrderDetailEntity
        {
            OrderDetailId = entity.OrderDetailId,
            OrderId = entity.OrderId,
            ProductId = entity.ProductId,
            Quantity = entity.Quantity,
            UnitPriceAtSale = entity.UnitPriceAtSale,
            SnapShotTax = entity.SnapShotTax,
            CommissionAmount = entity.CommissionAmount,
            SubTotal = entity.SubTotal
        };
    }
}

