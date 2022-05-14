using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Extensions
{
    public static class RateLimitExtension
    {
        public static void ConfigureRateLimit(this IServiceCollection services)
        {
            // 5 requests are allowed in 10 mins for any(*) endpoint
            var rateLimitRules = new List<RateLimitRule>
            { 
                new RateLimitRule()
                {
                    Endpoint = "*",
                    Limit= 5,
                    Period = "10m"
                }
            };

            services.Configure<IpRateLimitOptions>(opt =>
            {
                opt.GeneralRules = rateLimitRules;
            });

            services.AddSingleton<IRateLimitCounterStore, MemoryCacheRateLimitCounterStore>();
            services.AddSingleton<IIpPolicyStore, MemoryCacheIpPolicyStore>();
            services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        }

    }
}
