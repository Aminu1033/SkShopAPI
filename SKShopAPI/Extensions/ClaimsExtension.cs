using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SKShopAPI.Extensions
{
    public static class ClaimsExtension
    {
        public static async Task ConfigureClaims(IServiceProvider sp)
        {

            var userManager = sp.GetRequiredService<UserManager<ShopUser>>();
            var user = await userManager.FindByEmailAsync("aminuumar26@gmail.com");

            if (user != null)
            {
                var claims = await userManager.GetClaimsAsync(user);
                if (!claims.Any(c => c.Type == "Admin"))
                {
                    var adminClaim = new Claim("Admin", "Administrator");
                    await userManager.AddClaimAsync(user, adminClaim);
                }
            }
        }
    }
}
