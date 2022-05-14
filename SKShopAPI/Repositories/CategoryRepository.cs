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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShopDbContext _dbContext;
        private readonly ILogger<CategoryRepository> _logger;

        public CategoryRepository(ShopDbContext dbContext, ILogger<CategoryRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }
        
        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await _dbContext.Categories.Include(p => p.Products).OrderBy(c => c.Name).ToListAsync();
        }
        
        public PagedList<Product> GetProductsForCategory(Guid id, RequestParamsBase requestParams)
        {
            var catExist = CategoryExist(id);

            if (!catExist)
            {
                return null;
            }
            var collection = _dbContext.Products.Where(p => p.Category.Id == id).Include(p => p.Category);

            Console.WriteLine($"\n GetProductsForCategory query command : \n {collection.ToQueryString()} \n");

            return PagedList<Product>.ToPagedList(collection, requestParams.PageNumber, requestParams.PageSize);
        } 
        
        public async Task<Product> GetProductForCategory(Guid id, Guid prodId)
        {
            
            //var product = _dbContext.Products.FirstOrDefault(p => p.Id == prodId && p.CategoryId == id);

            var product = await _dbContext.Products.Include(c => c.Category)
                                .FirstOrDefaultAsync(p => p.Id == prodId && p.CategoryId == id);
            return product;
        }
       
        public async Task<Category> GetCategoryAsync(Guid id)
        { 
            var category = await _dbContext.Categories
                                .Include(p => p.Products).FirstOrDefaultAsync(c => c.Id == id); 
            return category;
        }

        public void CreateCategory(Category category)
        {
            _dbContext.Categories.Add(category);
        }

        public void CreateProductForCategory(Product product)
        {
            _dbContext.Products.Add(product); 
        }

        public void DeleteCategory(Category category)
        {
            _dbContext.Remove(category);
        }

        public void UpdateCategory(Category category)
        {     

        }

        public bool CategoryExist(Guid catId)
        {
            //_logger.LogInformation("\n CategoryExist method called \n");

            return _dbContext.Categories.Any(c => c.Id == catId);
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
