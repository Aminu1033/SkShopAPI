using SKShopAPI.Entities;
using SKShopAPI.Models;
using SKShopAPI.Pagination;
using SKShopAPI.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public interface IProductRepository
    {
        PagedList<Product> GetProducts(ProductResourceParams resourceParams);
        Task<IEnumerable<Product>> GetAllProductsAsync(ProductResourceParams resourceParams);
        Task<Product> GetProductAsync(Guid id);
        public void UpdateProduct(Product product);
        void CreateProduct(Product product);
        void DeleteProduct(Product product); 
        Task<bool> SaveAsync();

        bool CategoryExist(Product product);
    }
}
