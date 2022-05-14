using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public interface IOrderRepository
    {
        Task<IEnumerable<Order>> GetOrdersAsync(); 
        Task<Order> GetOrderAsync(Guid id);
        public void UpdateOrder(Order order);
        void CreateOrder(Order order);
        void DeleteOrder(Order order);
        Task<bool> SaveAsync();
        bool OrderExist(Order order);
    }
}
