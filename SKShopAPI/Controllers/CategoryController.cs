using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using SKShopAPI.Parameters;
using SKShopAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/categories")]
    [Produces("application/json", "application/xml")]
    [Consumes("application/json", "application/xml")]
    [ResponseCache(CacheProfileName = "OneHourCacheDuration")]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Get all Categories
        /// </summary> 
        /// <returns>Returns ActionResult of Categories</returns>
        /// <response code="200">**Returns all Categories**</response>
        [HttpGet] 
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetCategories()
        {
            var categories = await _categoryRepository.GetCategoriesAsync();
            if (categories == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }

        /// <summary>
        /// Get a Category by id
        /// </summary>
        /// <param name="id">**The id of the Category**</param>
        /// <returns>Returns ActionResult of CategoryDto</returns>
        /// <response code="200">**Returns the requested Category**</response>
        [HttpGet("{id}", Name = "GetCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoryDto>> GetCategory(Guid id)
        {
            var category = await _categoryRepository.GetCategoryAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<CategoryDto>(category));
        }

        /// <summary>
        /// Get Products for Category
        /// </summary>
        /// <param name="catId">**The id of the Category**</param>
        /// <param name="resourceParams">**Request parameters**</param>
        /// <returns>Returns a ActionResult of collection Products</returns>
        /// <response code="200">**Returns all Products for a particular Category**</response>
        [HttpGet("{catId}/products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<ProductDto>> GetProductsForCategory(Guid catId, [FromQuery] ProductResourceParams resourceParams)
        {
            var productForCategoryFromDb = _categoryRepository.GetProductsForCategory(catId, resourceParams);

            if (productForCategoryFromDb == null)
            {
                return NotFound();
            }

            Response.Headers.Add("Pagination", JsonSerializer.Serialize(productForCategoryFromDb.MetaData));

            return Ok(_mapper.Map<IEnumerable<ProductDto>>(productForCategoryFromDb));
        }

        /// <summary>
        /// Get a Product for Category
        /// </summary>
        /// <param name="id">**The id of the Category**</param>
        /// <param name="prodId">**The id of the Product**</param>
        /// <returns>Returns ActionResult of Product</returns>
        /// <response code="200">**Returns a particular Product for a particular Category**</response>
        [HttpGet("{id}/products/{prodId}", Name = "GetProductForCategory")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductDto>> GetProductForCategory(Guid id, Guid prodId)
        {
            var catExist = _categoryRepository.CategoryExist(id);
            if (!catExist)
            {
                return NotFound();
            }

            var productFromDataStore = await _categoryRepository.GetProductForCategory(id, prodId);


            if (productFromDataStore == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<ProductDto>(productFromDataStore));
        }

        /// <summary>
        /// Create a Category
        /// </summary>
        /// <param name="categoryForCreationDto">**Category for creation Model**</param>
        /// <returns>Returns ActionResult of Category</returns>
        /// <response code="201">**Returns the created Category**</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<Category>> CreateCategory([FromBody] CategoryForCreationDto categoryForCreationDto)
        { 
            var newCategory = _mapper.Map<Category>(categoryForCreationDto); 
            _categoryRepository.CreateCategory(newCategory);
            await _categoryRepository.SaveAsync();
            var categoryToReturn = _mapper.Map<CategoryDto>(newCategory);
            return CreatedAtRoute(nameof(GetCategory), new { id = newCategory.Id }, categoryToReturn);
        }

        /// <summary>
        /// Create a Product for a Category
        /// </summary>
        /// <param name="id">**Category id**</param>
        /// <param name="productForCreationDto">**Product for creation Model**</param>
        /// <returns>Returns ActionResult of type Product Dto</returns>
        /// <response code="201">**Returns the created Product**</response>
        [HttpPost("{id}/products")]
        [ProducesResponseType(StatusCodes.Status201Created)] 
        [ProducesResponseType(StatusCodes.Status404NotFound)] 
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)] 
        public ActionResult<ProductDto> CreateProductForCategory(Guid id,
            ProductForCreationDto productForCreationDto)
        {
            if (productForCreationDto.CategoryId == Guid.Empty)
            {
                return UnprocessableEntity(new { Error = "Category id can not be null or empty" });
            } 

            var category = _categoryRepository.CategoryExist(id);
            if (!category)
            {
                return NotFound(new { ErrorMessage = "The Category id does not exist" });
            }

            var newProduct = _mapper.Map<Product>(productForCreationDto);
            _categoryRepository.CreateProductForCategory(newProduct);

            _categoryRepository.GetProductForCategory(id, newProduct.Id);
            var productToReturn = _mapper.Map<ProductDto>(newProduct);
            return CreatedAtRoute(nameof(GetProductForCategory),
                        new { id, prodId = newProduct.Id }, productToReturn);
        }

        /// <summary>
        /// Update a Category
        /// </summary>
        /// <param name="id">**The id of the Category**</param>
        /// <param name="categoryForUpdateDto">**Category for update Model**</param>
        /// <returns>Returns ActionResult</returns>
        /// <response code="204">**Returns NoContent**</response>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> UpdateCategory(Guid id, CategoryForUpdateDto categoryForUpdateDto)
        {
            var categoryToUpdate = await _categoryRepository.GetCategoryAsync(id);

            if (categoryToUpdate == null)
            {
                return NotFound();
            }

            var updatedCategory = _mapper.Map(categoryForUpdateDto, categoryToUpdate);

            _categoryRepository.UpdateCategory(updatedCategory);
            await _categoryRepository.SaveAsync();

            return NoContent();
        }


        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <param name="id">**The id of the Category to be deleted**</param>
        /// <returns>Returns ActionResult</returns>
        /// <response code="204">**Returns NoContent**</response>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]
        public async Task<ActionResult> DeleteCategory(Guid id)
        {
            var categoryToDelete = await _categoryRepository.GetCategoryAsync(id);
            if (categoryToDelete == null)
            {
                return NotFound();
            }

            _categoryRepository.DeleteCategory(categoryToDelete);
            await _categoryRepository.SaveAsync();

            return NoContent();
        }

        /// <summary>
        /// Categories Options
        /// </summary>
        /// <returns>Returns IActionResult</returns>
        /// <response code="200">**Returns all Http methods supported**</response>
        [HttpOptions]
        [ProducesResponseType(StatusCodes.Status200OK)] 
        public IActionResult GetProductsOptions()
        {
            Response.Headers.Add("Accept", "GET, POST, PUT, DELETE");

            return Ok();
        }

    }
}
