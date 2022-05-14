using Microsoft.EntityFrameworkCore;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public class ProductCollectionRepository : IProductCollectionRepository
    {
        private readonly ShopDbContext _dbContext;

        public ProductCollectionRepository(ShopDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductCollectionAsync(IEnumerable<Guid> ids)
        {
            return await _dbContext.Products.Where(p => ids.Contains(p.Id))
                                .Include(p => p.Category).ToListAsync();
        }

        public void CreateProductCollectionAsync(IEnumerable<Product> collection)
        {
            _dbContext.Products.AddRange(collection);
        }

        public async Task<bool> SaveAsync()
        {
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
