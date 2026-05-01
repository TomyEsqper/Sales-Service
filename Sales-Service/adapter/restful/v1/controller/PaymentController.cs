using Microsoft.AspNetCore.Mvc;
using Sales_Service.application.Service;
using Sales_Service.adapter.restful.v1.controller.Mapper;
using Sales_Service.adapter.restful.v1.controller.Entity;

namespace Sales_Service.adapter.restful.v1.controller;

[ApiController]
[Route("api/v1/payments")] // Ruta base
public class PaymentController : ControllerBase
{
    private readonly IPaymentService _paymentService;
    private readonly IAdapterMapper _adapterMapper;

    public PaymentController(IPaymentService paymentService, IAdapterMapper adapterMapper)
    {
        _paymentService = paymentService;
        _adapterMapper = adapterMapper;
    }

    // Cumpliendo con tu tabla: POST /payments/process
    [HttpPost("process")]
    public ActionResult<AdapterPaymentEntity> ProcessPayment([FromBody] AdapterPaymentEntity payment)
    {
        var domain = _adapterMapper.ToDomainPayment(payment);
        var processed = _paymentService.ProcessPayment(domain);
        var adapterResult = _adapterMapper.ToAdapterPayment(processed);
        
        return Ok(adapterResult); 
    }
}