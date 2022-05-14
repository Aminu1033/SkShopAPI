using SKShopAPI.Entities;
using SKShopAPI.Pagination;
using SKShopAPI.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoriesAsync();
        PagedList<Product> GetProductsForCategory(Guid id, RequestParamsBase requestParams);
        Task<Product> GetProductForCategory(Guid id, Guid prodId);
        Task<Category> GetCategoryAsync(Guid id);
        void CreateCategory(Category category);
        void CreateProductForCategory(Product product);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        bool CategoryExist(Guid catId);
        Task<bool> SaveAsync();

    }
}
