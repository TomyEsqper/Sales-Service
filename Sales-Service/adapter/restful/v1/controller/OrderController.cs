using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Sales_Service.application.Service;
using Sales_Service.adapter.restful.v1.controller.Mapper;
using Sales_Service.adapter.restful.v1.controller.Entity;

namespace Sales_Service.adapter.restful.v1.controller;

[ApiController]
[Route("api/v1/orders")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    private readonly IAdapterMapper _adapterMapper;

    public OrderController(IOrderService orderService, IAdapterMapper adapterMapper)
    {
        _orderService = orderService;
        _adapterMapper = adapterMapper;
    }

    [HttpGet]
    public ActionResult<List<AdapterOrderEntity>> GetAll()
    {
        var domainList = _orderService.GetAllOrders();
        var adapterList = _adapterMapper.ToAdapterOrderList(domainList);
        return Ok(adapterList);
    }

    [HttpGet("{id}")]
    public ActionResult<AdapterOrderEntity> GetById(Guid id) // <-- Cambiado a Guid
    {
        var domain = _orderService.GetOrderById(id);
        if (domain == null) return NotFound();
        var adapter = _adapterMapper.ToAdapterOrder(domain);
        return Ok(adapter);
    }

    [HttpPost]
    public ActionResult<AdapterOrderEntity> CreateOrder([FromBody] AdapterOrderEntity order)
    {
        var domain = _adapterMapper.ToDomainOrder(order);
        var created = _orderService.CreateOrder(domain);
        var adapterResult = _adapterMapper.ToAdapterOrder(created);
        
        // <-- Cambiado adapterResult.Id por adapterResult.OrderId
        return CreatedAtAction(nameof(GetById), new { id = adapterResult.OrderId }, adapterResult); 
    }
}
