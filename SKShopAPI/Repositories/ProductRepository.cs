using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using SKShopAPI.Pagination;
using SKShopAPI.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShopDbContext _dbContext;
        private readonly ILogger<ProductRepository> _logger;

        public ProductRepository(ShopDbContext dbContext, ILogger<ProductRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public void CreateProductAsync(Product product)
        {
            _dbContext.Products.Add(product);

            _dbContext.SaveChanges();
        }

        public async Task<Product> GetProductAsync(Guid id)
        {
            return await _dbContext.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync(ProductResourceParams resourceParams)
        { 
            if (resourceParams.NoPaging && !string.IsNullOrWhiteSpace(resourceParams.Category))
            {
                var categoryName = resourceParams.Category.Trim();
                return  await _dbContext.Products.Include(p => p.Category)
                            .Where(p => p.Category.Name == categoryName).ToListAsync();
            }
            return await _dbContext.Products.Include(p=>p.Category).ToListAsync();
        }

        public PagedList<Product> GetProducts(ProductResourceParams resourceParams)
        {
            IQueryable<Product> collection = _dbContext.Products.Include(p => p.Category);

            //_logger.LogInformation(collection.ToQueryString()); 

            if (!string.IsNullOrWhiteSpace(resourceParams.SearchQuery))
            {
                string searchQuery = resourceParams.SearchQuery.Trim(); 

                collection = collection.Where(p => p.Name.Contains(searchQuery) ||
                                            p.Color.Contains(searchQuery));  
            }

            if (!string.IsNullOrWhiteSpace(resourceParams.SearchQuery) && resourceParams.Exact)
            {
                string searchQuery = resourceParams.SearchQuery.Trim();  
                collection = collection.Where(p => p.Name == searchQuery); 
            }

            
            if (!string.IsNullOrWhiteSpace(resourceParams.Category))
            {
                string categoryName = resourceParams.Category.Trim();
                collection = collection.Where(p => p.Category.Name == categoryName); 
            }

            if (!string.IsNullOrWhiteSpace(resourceParams.Color))
            {
                string color = resourceParams.Color.Trim();
                collection = collection.Where(p => p.Color == color); 
            }

            if (resourceParams.LessThan50)
            {
                collection = collection.Where(p => p.Price <= 50);
            }

            if (resourceParams.Between50And100)
            {
                collection = collection.Where(p => p.Price > 50 && p.Price <= 100 ); 
            }
            
            if (resourceParams.HigherThan100)
            {
                collection = collection.Where(p => p.Price > 100); 
            }

            if (resourceParams.ItemsOfTheWeek)
            {
                collection = collection.Where(p => p.IsItemOfTheWeek);
            }
              
            return PagedList<Product>.ToPagedList(collection, resourceParams.PageNumber, resourceParams.PageSize);
        }
              

        public void UpdateProduct(Product product)
        { 
            
        }
         
        public void CreateProduct(Product product)
        { 
            _dbContext.Products.Add(product);
        }

        public void DeleteProduct(Product product)
        {
            _dbContext.Products.Remove(product);
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public bool CategoryExist(Product product)
        {
            return _dbContext.Categories.Any(c => c.Id == product.CategoryId);
        }
    }
}
