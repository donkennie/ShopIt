using Microsoft.AspNetCore.Mvc;
using ShopIt.Services;
using ShopIt.DTOs;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System.Net;
using Microsoft.AspNetCore.Authorization;


namespace ShopIt.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderService _orderService;
        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("createOrder")]
        public async Task<IActionResult> CreateOrder(CreateOrderDTO createOrderDTO)
        {
            try
            {
                var order = await _orderService.CreateOrder(createOrderDTO);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("getOrderById")]
        public async Task<IActionResult> GetOrdersById(Guid orderId)
        {
            try
            {
                var orders = await _orderService.GetOrdersById(orderId);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpGet("getOrderByEmail")]
        public async Task<IActionResult> GetOrdersByEmail(string Email)
        {
            try
            {
                var orders = await _orderService.GetOrdersByEmail(Email);
                return Ok(orders);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
