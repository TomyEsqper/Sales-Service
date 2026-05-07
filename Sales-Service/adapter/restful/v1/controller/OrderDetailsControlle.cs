using Microsoft.AspNetCore.Mvc;
using Sales_Service.application.Service;
using Sales_Service.adapter.restful.v1.controller.Mapper;
using Sales_Service.domain.Entity;

namespace Sales_Service.adapter.restful.v1.controller;

[ApiController]
[Route("api/v1/orderdetails")]
public class OrderDetailsController : ControllerBase
{
    private readonly IOrderDetailsService _orderDetailsService;

    public OrderDetailsController(IOrderDetailsService orderDetailsService)
    {
        _orderDetailsService = orderDetailsService;
    }

    /// <summary>
    /// Obtiene un detalle de orden por su ID
    /// </summary>
    [HttpGet("{id}")]
    public ActionResult<DomainOrderDetailEntity> GetOrderDetailById(int id)
    {
        var domain = _orderDetailsService.GetOrderDetailById(id);
        if (domain == null) return NotFound();
        
        return Ok(domain);
    }

    /// <summary>
    /// Obtiene todos los detalles de una orden específica
    /// </summary>
    [HttpGet("order/{orderId}")]
    public ActionResult<List<DomainOrderDetailEntity>> GetOrderDetailsByOrderId(Guid orderId)
    {
        var domain = _orderDetailsService.GetOrderDetailsByOrderId(orderId);
        if (domain == null || domain.Count == 0) return NotFound();
        
        return Ok(domain);
    }
}