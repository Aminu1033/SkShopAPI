using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using SKShopAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/orders")]
    [ResponseCache(CacheProfileName = "OneHourCacheDuration")]
    [Produces("application/json", "application/xml")]
    [Consumes("application/json", "application/xml")]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]

    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<OrderController> _logger;

        public OrderController(IOrderRepository orderRepository, IMapper mapper,
            ILogger<OrderController> logger)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Get all orders
        /// </summary>
        /// <returns>Returns action result of orders</returns>
        /// <response code="200">**Returns all orders**</response>
        [HttpGet(Name = "GetOrders")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await _orderRepository.GetOrdersAsync();
            if (orders == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<OrderDto>>(orders));
        }


        /// <summary>
        /// Get an order by id
        /// </summary>
        /// <param name="id">**The id of the order**</param>
        /// <returns>Returns action result of order</returns>
        /// <response code="200">**Returns an order**</response>
        [HttpGet("{id}", Name = "GetOrder")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var order = await _orderRepository.GetOrderAsync(id);
            if (order == null)
            {
                NotFound();
            }

            return Ok(_mapper.Map<OrderDto>(order));
        }

        /// <summary>
        /// Delete an order by id
        /// </summary>
        /// <param name="orderId">**The id of the order to delete**</param> 
        /// <returns>Return Action result</returns>
        /// <response code="204">**Returns No content**</response>
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]
        [HttpDelete("{orderId}", Name = "DeleteOrder")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public async Task<ActionResult> DeleteOrder(Guid orderId)
        {
            var order = await _orderRepository.GetOrderAsync(orderId);
            if (order == null)
            {
                return NotFound($"No order exist with id: {orderId}");
            }
            _orderRepository.DeleteOrder(order);
            await _orderRepository.SaveAsync();
            return NoContent();
        }


    }
}
