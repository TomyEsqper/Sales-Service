using Sales_Service.domain.Entity;

namespace Sales_Service.application.Service;

public interface IPaymentService
{
    DomainPaymentEntity ProcessPayment(DomainPaymentEntity payment);
}