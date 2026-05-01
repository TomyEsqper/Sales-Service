using System;
using System.Collections.Generic;
using Sales_Service.domain.Entity;
using Sales_Service.adapter.restful.v1.controller.Entity;

namespace Sales_Service.adapter.restful.v1.controller.Mapper;

public class AdapterMapper : IAdapterMapper
{
    public AdapterOrderEntity ToAdapterOrder(DomainOrderEntity domainOrder)
    {
        if (domainOrder == null) throw new ArgumentNullException(nameof(domainOrder));
        
        return new AdapterOrderEntity
        {
            OrderId = domainOrder.OrderId,
            BuyerId = domainOrder.BuyerId,
            OrderDate = domainOrder.OrderDate,
            TotalAmount = domainOrder.TotalAmount,
            PaymentStatus = domainOrder.PaymentStatus,
            EscrowStatus = domainOrder.EscrowStatus,
            Version = domainOrder.Version
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
            OrderId = adapterOrder.OrderId,
            BuyerId = adapterOrder.BuyerId,
            OrderDate = adapterOrder.OrderDate,
            TotalAmount = adapterOrder.TotalAmount,
            PaymentStatus = adapterOrder.PaymentStatus,
            EscrowStatus = adapterOrder.EscrowStatus,
            Version = adapterOrder.Version
        };
    }
    
    public DomainPaymentEntity ToDomainPayment(AdapterPaymentEntity adapter)
    {
        if (adapter == null) return null!;
        return new DomainPaymentEntity
        {
            PaymentId = adapter.PaymentId,
            OrderId = adapter.OrderId,
            PaymentProvider = adapter.PaymentProvider,
            TransactionReference = adapter.TransactionReference,
            AmountPaid = adapter.AmountPaid,
            PaymentDate = adapter.PaymentDate,
            Status = adapter.Status
        };
    }

    public AdapterPaymentEntity ToAdapterPayment(DomainPaymentEntity domain)
    {
        if (domain == null) return null!;
        return new AdapterPaymentEntity
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
}
