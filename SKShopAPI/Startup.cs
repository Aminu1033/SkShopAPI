using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using SKShopAPI.Extensions;
using SKShopAPI.Repositories;
using System;
using System.IO;
using System.Reflection;

namespace SKShopAPI
{
    public class Startup
    { 
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration; 
        }

        public IConfiguration Configuration { get; } 

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddResponseCaching();
              

            services.AddControllers(configure =>
           {
               //configure.RespectBrowserAcceptHeader = true;

               //Return status code 406 not acceptable the media type
               //requested by the client is not supported by our API
               configure.ReturnHttpNotAcceptable = true;

               //Producing correct responses
               configure.Filters.Add(
                  new ProducesResponseTypeAttribute(StatusCodes.Status400BadRequest));
               configure.Filters.Add(
                   new ProducesResponseTypeAttribute(StatusCodes.Status406NotAcceptable));
               configure.Filters.Add(
                   new ProducesResponseTypeAttribute(StatusCodes.Status500InternalServerError));
               configure.Filters.Add(
                   new ProducesDefaultResponseTypeAttribute()); 

           //Configure reponse caching profile 
               configure.CacheProfiles.Add("OneHourCacheDuration", new CacheProfile
               {
                   Duration = 3600
               });

           }).AddNewtonsoftJson(setupAction =>
                {
                    setupAction.SerializerSettings.ContractResolver =
                        new CamelCasePropertyNamesContractResolver();
                })
           .AddXmlDataContractSerializerFormatters();


            // Adding Authorization
            services.AddAuthorization(option =>
            {
                option.AddPolicy("AdminOnly", policyBuilder =>
                {
                    policyBuilder.RequireRole("Administrator");
                });
                
                option.AddPolicy("NormalUser", policyBuilder =>
                {
                    policyBuilder.RequireRole("User");
                });
                 
            });

            // Adding Authenication and configure (JWT) service for the api user
            services.AddAuthentication();
            services.ConfigureIdentity();
            services.ConfigureJWT(Configuration);

             
            // Registering repositories
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductCollectionRepository, ProductCollectionRepository>(); 
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IShopUserRepository, ShopUserRepository>();  

            //// Entity Framework Core and SqlServer setup ShopUser Database
            services.AddDbContext<ShopDbContext>(option =>
            {
                option.UseSqlServer(Configuration.GetConnectionString("DefaultConString"));
            });
                         

            //AutoMapper service
            services.AddAutoMapper(typeof(Startup));

            //Swagger setup
            services.AddSwaggerGen(setupAction =>
            {
                setupAction.SwaggerDoc("SkShopProductsApi",
                    new Microsoft.OpenApi.Models.OpenApiInfo()
                    {
                        Title = "SkShop Products API",
                        Version = "1.0.0",
                        Description = "Through this API you can access Categories and Products",
                        Contact = new Microsoft.OpenApi.Models.OpenApiContact()
                        {
                            Name = "Aminu Umar",
                            Email = "aminuumar26@gmail.com",
                            Url = new Uri("https://skdev.com.ng")
                        },
                        License = new Microsoft.OpenApi.Models.OpenApiLicense()
                        {
                            Name = "MIT License",
                            Url = new Uri("https://opensource.org/licenses(MIT)")
                        }
                    });


                var xmlCommentsFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlcommentsFullPath = Path.Combine(AppContext.BaseDirectory, xmlCommentsFile);

                setupAction.IncludeXmlComments(xmlcommentsFullPath);
            });

            services.ConfigureCors(); 
           
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider sp)
        {
            // Adding Claims configuration  
            ClaimsExtension.ConfigureClaims(sp)
                .GetAwaiter().GetResult();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); 
            } 

            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseStatusCodePages();

            //Global ExceptionHandler
            app.GlobalExceptionHandler();

            app.UseHttpsRedirection();

            app.UseResponseCaching(); 

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            app.UseSwaggerUI(setupAction=>
            {
                setupAction.SwaggerEndpoint("/swagger/SkShopProductsApi/swagger.json", "SkShop Products Api");
                setupAction.RoutePrefix = "";
            }); 

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
