using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.Entity;
using Sales_Service.infrastructure.Mapper;
using System.Collections.Generic;
using System.Linq;

namespace Sales_Service.infrastructure.DbContext;

public class Repository
{
    private readonly AppDbContext _context;
    private readonly IInfrastructureMapper _mapper;

    public Repository(AppDbContext context, IInfrastructureMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public List<DomainOrderEntity> GetAllOrders()
    {
        var entities = _context.Orders.ToList();
        var list = new List<DomainOrderEntity>();
        foreach (var e in entities)
        {
            list.Add(_mapper.ToDomainOrder(e));
        }
        return list;
    }
    
    public DomainOrderEntity GetOrderById(Guid id)
    {
        var entity = _context.Orders.FirstOrDefault(o => o.OrderId == id);
        if (entity == null) return null!;
        
        return _mapper.ToDomainOrder(entity);
    }

 

    public DomainOrderEntity CreateOrder(DomainOrderEntity order)
    {
        var entity = _mapper.ToInfrastructureOrder(order);
        _context.Orders.Add(entity);
        _context.SaveChanges();
        return _mapper.ToDomainOrder(entity);
    }
    
   public DomainPaymentEntity CreatePayment(DomainPaymentEntity payment)
    {
        var entity = _mapper.ToInfrastructurePayment(payment);
        _context.Payments.Add(entity);
        _context.SaveChanges();
        
        return _mapper.ToDomainPayment(entity);
    }

    public DomainPaymentEntity GetPaymentById(Guid id)
    {
        // Buscamos el pago en la BD por su ID
        var entity = _context.Payments.FirstOrDefault(p => p.PaymentId == id);
        if (entity == null) return null!;

        // Convertimos de Infrastructure a Domain usando el mapper
        return _mapper.ToDomainPayment(entity);
    }

    public DomainOrderDetailEntity GetOrderDetailById(int id)
    {
        var entity = _context.OrderDetails.FirstOrDefault(od => od.OrderDetailId == id);
        if (entity == null) return null!;
        
        return _mapper.ToDomainOrderDetail(entity);
    }
    
    public List<DomainOrderDetailEntity> GetOrderDetailsByOrderId(Guid orderId)
    {
        // Buscamos todos los detalles de una orden específica
        var entities = _context.OrderDetails
            .Where(od => od.OrderId == orderId)
            .ToList();
    
        var list = new List<DomainOrderDetailEntity>();
        foreach (var e in entities)
        {
            list.Add(_mapper.ToDomainOrderDetail(e));
        }
        return list;
    }
}
