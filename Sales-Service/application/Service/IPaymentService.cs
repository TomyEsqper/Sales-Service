using Sales_Service.domain.Entity;

namespace Sales_Service.application.Service;

public interface IPaymentService
{
    DomainPaymentEntity ProcessPayment(DomainPaymentEntity payment);
    
    // Obtener un pago por su ID
    DomainPaymentEntity GetPaymentById(Guid id);
    
}