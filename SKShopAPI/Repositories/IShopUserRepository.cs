using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public interface IShopUserRepository
    {
        Task<JwtSecurityToken> CreateToken();
        Task<bool> ValidateUser(UserForAuthDto shopUserForAuth);
        Task<bool> CreateOrderForUser(Order order);
        Task<Order> GetOrderForUser(Guid orderId, Guid userId);
        Task<IEnumerable<Order>> GetOrdersForUser(Guid userId);
    }
}
