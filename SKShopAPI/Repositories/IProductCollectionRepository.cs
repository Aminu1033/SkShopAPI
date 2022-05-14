using SKShopAPI.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SKShopAPI.Repositories
{
    public interface IProductCollectionRepository
    {        
        Task<IEnumerable<Product>> GetProductCollectionAsync(IEnumerable<Guid> ids);

        void CreateProductCollectionAsync(IEnumerable<Product> collection);

        Task<bool> SaveAsync();
    }
}