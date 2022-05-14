using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http; 
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using SKShopAPI.Entities;
using SKShopAPI.Helpers;
using SKShopAPI.Models;
using SKShopAPI.Pagination;
using SKShopAPI.Parameters;
using SKShopAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;


namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/products")] 
    [Produces("application/json", "application/xml")]
    [Consumes("application/json", "application/xml")]
    //[ResponseCache(CacheProfileName = "OneHourCacheDuration")] 
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepository productReposiory, IMapper mapper)
        {
            _productRepository = productReposiory;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all products
        /// </summary>
        /// <param name="productResourceParams">Query parameters for **searching, sorting, filtering and Ordering products**</param>
        /// <returns>Returns an ActionResult of PagedList of type ProductDto</returns>
        /// <response code="200">**Returns a collection of Products**</response>
        [HttpGet(Name = "GetProducts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<ProductDto>>> GetProducts([FromQuery] ProductResourceParams productResourceParams)
        {
            if (productResourceParams.NoPaging)
            {
               var productsFromDb =await _productRepository.GetAllProductsAsync(productResourceParams);
                return Ok(_mapper.Map<IEnumerable<ProductDto>>(productsFromDb));
            }
            var productsFromDataStore = _productRepository.GetProducts(productResourceParams);

            if (productsFromDataStore == null)
            {
                return NotFound();
            }
     
            Response.Headers.Add("Pagination", JsonSerializer.Serialize(productsFromDataStore.MetaData));
            
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productsFromDataStore));
        }

        /// <summary>
        /// Get a product by Id
        /// </summary>
        /// <param name="id">**The Id of the product to get**</param>
        /// <returns>Returns an ActionResult of type ProductDto</returns>
        /// <response code="200">**Returns the requested Product**</response>
        [HttpGet("{id}", Name = "GetProduct")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        public async Task<ActionResult<ProductDto>> GetProduct(Guid id)
        {
            var productFromDataStore = await _productRepository.GetProductAsync(id);
            if (productFromDataStore == null)
            {
                return NotFound();
            }
          
            return Ok(_mapper.Map<ProductDto>(productFromDataStore));
        }

        /// <summary>
        /// Create a new product
        /// </summary>
        /// <param name="productForCreationDto">**Model for creating new product**</param> 
        /// <returns>Returns a Task of ActionResult of type Product</returns>
        /// <response code="201">**Returns the created Product Dto**</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<Product>> CreateProduct(ProductForCreationDto productForCreationDto)
        {
            if (productForCreationDto.CategoryId == Guid.Empty)
            {
                return UnprocessableEntity(new { Error = "Category id can not be null or empty" });
            }

            if (productForCreationDto.ImgFile != null && productForCreationDto.ImgUrl == null)
            {
                var randomName = FileManager.RandomName();
                await FileManager.Savefile(productForCreationDto.ImgFile, randomName);
                productForCreationDto.ImgUrl = $"https://localhost:5001/{randomName}";
            }

            productForCreationDto.ImgFile = null;

            var newProduct = _mapper.Map<Product>(productForCreationDto);

            var catExist = _productRepository.CategoryExist(newProduct);
            if (!catExist)
            {
                return NotFound(new { ErrorMessage = "The Category id does not exist"});
            }

            _productRepository.CreateProduct(newProduct);

            await _productRepository.SaveAsync();

            await _productRepository.GetProductAsync(newProduct.Id);
            var productToReturn = _mapper.Map<ProductDto>(newProduct);

            return CreatedAtRoute(nameof(GetProduct), new { id = newProduct.Id }, productToReturn);
        }


        /// <summary>
        /// Update an existing Product (Full update)
        /// </summary>
        /// <param name="id">**The Id of the Product to update**</param>
        /// <param name="productForUpdateDto">**Model for full update**</param>
        /// <returns>**Returns NoContent**</returns> 
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> UpdateProduct(Guid id, [FromBody] ProductForUpdateDto productForUpdateDto)
        {
            if (productForUpdateDto.CategoryId == Guid.Empty)
            {
                return UnprocessableEntity(new { Error = "Category id can not be null or empty" });
            }

            var product = _mapper.Map<Product>(productForUpdateDto);
            var categoryExist = _productRepository.CategoryExist(product);

            if (!categoryExist)
            {
                return UnprocessableEntity();
            }

            var productFromDb = await _productRepository.GetProductAsync(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            var updatedProduct = _mapper.Map(productForUpdateDto, productFromDb);

            _productRepository.UpdateProduct(updatedProduct);
            await _productRepository.SaveAsync();

            return NoContent();
        }


        /// <summary>
        /// Partially Update a Product (Partial update)
        /// </summary>
        /// <param name="id">**The Id of the Product to update**</param>
        /// <param name="patchDoc">**The patch document**</param>
        /// <returns>**Returns NoContent**</returns>
        /// <remarks>
        /// Sample request (Partially update the **Name** of a **Product**)  
        /// Patch api/products/id  
        /// [  
        /// {  
        /// "op" : "replace",  
        /// "path" : /name",  
        /// "value" : "new name"  
        /// {  
        /// [  
        /// </remarks>
        [HttpPatch("{id}")]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> PartialUpdateProduct(Guid id, [FromBody] JsonPatchDocument<ProductForUpdateDto> patchDoc)
        { 
            var productFromDb = await _productRepository.GetProductAsync(id);
            if (productFromDb == null)
            {
                return NotFound();
            }

            var productToPatch = _mapper.Map<ProductForUpdateDto>(productFromDb);

            patchDoc.ApplyTo(productToPatch, ModelState);

            if (!TryValidateModel(patchDoc))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(productToPatch, productFromDb);

             _productRepository.UpdateProduct(productFromDb);
            await _productRepository.SaveAsync();

            return NoContent();
        }


        /// <summary>
        /// Delete a product
        /// </summary>
        /// <param name="id">**The id of the product to delete**</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">**Returns NoContent**</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy ="AdminOnly")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var productToDelete = await _productRepository.GetProductAsync(id);
            if (productToDelete == null)
            {
                return NotFound();
            }
            _productRepository.DeleteProduct(productToDelete);
            await _productRepository.SaveAsync();

            return NoContent();
        }

        /// <summary>
        /// Get products options
        /// </summary>
        /// <returns>Returns IActionResult</returns>
        /// <response code="200">**Returns all Http methods supported**</response>
        [HttpOptions] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProductsOptions()
        {
            Response.Headers.Add("Accept", "GET, POST, PUT, PATCH, DELETE");
            return Ok();
        }
    }
}
