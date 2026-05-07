using Sales_Service.application.Service;
using Sales_Service.domain.Entity;
using Sales_Service.infrastructure.DbContext;

namespace Sales_Service.domain;

public class PaymentServiceImp : IPaymentService
{
    private readonly Repository _repository;

    public PaymentServiceImp(Repository repository)
    {
        _repository = repository;
    }

    public DomainPaymentEntity ProcessPayment(DomainPaymentEntity payment)
    {
        // Aquí en el futuro puedes agregar lógica de validación (ej. verificar si la orden ya está pagada)
        return _repository.CreatePayment(payment);
    }


    public DomainPaymentEntity GetPaymentById(Guid id)  // ← NUEVO MÉTODO
    {
        return _repository.GetPaymentById(id);
    }
}