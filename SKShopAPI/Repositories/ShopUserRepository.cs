using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public class ShopUserRepository : IShopUserRepository
    {
        private readonly UserManager<ShopUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly ShopDbContext _dbContext;
        private ShopUser _shopUser;

        public ShopUserRepository(UserManager<ShopUser> userManager,
            IConfiguration configuration, ShopDbContext dbContext)
        {
            _userManager = userManager;
            _configuration = configuration;
            _dbContext = dbContext; 
        }

        public async Task<bool> ValidateUser(ShopUserForAuthDto shopUserForAuth)
        {
            _shopUser = await _userManager.FindByEmailAsync(shopUserForAuth.Email);

            return _shopUser != null && await _userManager.CheckPasswordAsync(_shopUser, shopUserForAuth.Password);
        }

        public async Task<JwtSecurityToken> CreateToken()
        {
            var signingCredentials = GetSigningCredentials();
            var claims = await GetClaims();

            return GenerateTokenOptions(signingCredentials, claims);
        }

        private SigningCredentials GetSigningCredentials()
        {
            var key = Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("SECRET"));
            var secret = new SymmetricSecurityKey(key);
            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        private async Task<List<Claim>> GetClaims()
        {
            var claims = new List<Claim>
                 {
                    new Claim(ClaimTypes.Email, _shopUser.Email)
                 };

            var roles = await _userManager.GetRolesAsync(_shopUser);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            } 

            return claims;
        }

        private JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtSettings = _configuration.GetSection("Jwt");
            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtSettings.GetSection("issuer").Value,
                audience: jwtSettings.GetSection("audience").Value,
                claims: claims,
                expires:
                DateTime.Now.AddHours(Convert.ToDouble(jwtSettings.GetSection("expires").Value)),
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        public async Task<bool> CreateOrderForUser(Order order)
        {
            _dbContext.Add(order);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<Order> GetOrderForUser(Guid userId, Guid orderId)
        {
            return await _dbContext.Orders.FirstOrDefaultAsync(o => o.Id == orderId && o.ShopUserId == userId.ToString());
        }

        public async Task<IEnumerable<Order>> GetOrdersForUser(Guid userId)
        {
            return await _dbContext.Orders.Where(o => o.ShopUserId == userId.ToString()).ToListAsync();
        }
    }
}
