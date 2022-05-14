using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SKShopAPI.DataAccess;
using SKShopAPI.Entities;
using SKShopAPI.ModelBinnders;
using SKShopAPI.Models;
using SKShopAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/productCollection")]
    [Produces("application/json", "application/xml")]
    [Consumes("application/json", "application/xml")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]
    public class ProductCollectionController : ControllerBase
    {
        private readonly ShopDbContext _dbContext;
        private readonly IProductCollectionRepository _productCollectionRepo;
        private readonly IMapper _mapper;
        private readonly ILogger<ProductCollectionController> _logger;

        public ProductCollectionController(ShopDbContext dbContext,
            IMapper mapper,
            IProductCollectionRepository productCollectionRepo,
            ILogger<ProductCollectionController> logger)
        {
            _dbContext = dbContext;
            _productCollectionRepo = productCollectionRepo;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Get collection of products by Ids
        /// </summary>
        /// <param name="ids">**Id of each product in the collection**</param>
        /// <returns>Returns an ActionResult of IEnumerable of type ProductDto</returns>
        /// <response code="200">**Returns a collection of Products by ids**</response>
        [HttpGet("ids", Name = "GetProductCollection")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProductCollection(
                                [ModelBinder(BinderType = typeof(ArrayModelBinder))] 
                                                                IEnumerable<Guid> ids)
        {
            if (ids == null)
            {
                return UnprocessableEntity("Ids can not be empty");
            }
            
            var productsFromDb = await _productCollectionRepo.GetProductCollectionAsync(ids);

            if (productsFromDb.Count() != ids.Count())
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productsFromDb)); 
        }

        /// <summary>
        /// Create a collection of product
        /// </summary>
        /// <param name="productCollection">**An Array of products to be created**</param>
        /// <returns>Returns ActionResult of IEnumerable of type Product</returns>
        /// <response code="201">**Returns a collection of Product created**</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<Product>>> CreateProducts([FromBody] IEnumerable<ProductForCreationDto> productCollection)
        {
            if (productCollection == null)
            {
                return BadRequest("Product collection is null");
            }

            var productsToCreate = _mapper.Map<IEnumerable<Product>>(productCollection);
            _productCollectionRepo.CreateProductCollectionAsync(productsToCreate);
            await _productCollectionRepo.SaveAsync();

            var productToReturn = _mapper.Map<IEnumerable<ProductDto>>(productsToCreate);

            var ids = string.Join(",", productToReturn.Select(c => c.Id));

            return CreatedAtRoute(nameof(GetProductCollection), new { ids }, productToReturn);
        }
    }
}
