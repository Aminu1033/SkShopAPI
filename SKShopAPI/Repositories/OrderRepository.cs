using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ShopDbContext _dbContext;
        private readonly ILogger<OrderRepository> _logger;

        public OrderRepository(ShopDbContext dbContext, ILogger<OrderRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        public bool OrderExist(Order order)
        {
            return _dbContext.Orders.Any(c => c.Id == order.Id);
        }

        public void CreateOrder(Order order)
        {
            _dbContext.Orders.Add(order);
        }

        public void DeleteOrder(Order order)
        {
            _dbContext.Orders.Remove(order);
        }

        public async Task<Order> GetOrderAsync(Guid id)
        {
            return await _dbContext.Orders.Include(o => o.CartItems)
                .FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _dbContext.Orders.ToListAsync();
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public void UpdateOrder(Order order) { }
    }
}
