using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SKShopAPI.Entities;
using SKShopAPI.Models;
using SKShopAPI.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Threading.Tasks;

namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/users")]
    [Produces("application/json", "application/xml")]
    [Consumes("application/json", "application/xml")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]

    public class ShopUserController : Controller
    {
        private readonly UserManager<ShopUser> _userManager;
        private readonly ILogger<ShopUserController> _logger;
        private readonly IMapper _mapper; 
        private readonly IShopUserRepository _shopUserRepository; 

        public ShopUserController(UserManager<ShopUser> userManager, ILogger<ShopUserController> logger,
            IMapper mapper,IShopUserRepository shopUserRepository)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper; 
            _shopUserRepository = shopUserRepository;
        }

        /// <summary>
        /// Get all shop users
        /// </summary>
        /// <returns>Returns a collection of shop users</returns>
        /// <response code="200">**Returns a collection of users**</response>
        [HttpGet(Name = "GetShopUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ShopUserDto>>> GetShopUsers()
        {
            var users = await _userManager.Users.ToListAsync();
            if (users == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<ShopUserDto>>(users));
        }

        /// <summary>
        /// Get shop user
        /// </summary>
        /// <param name="id">**The id of the user**</param>
        /// <returns>Returns shop user by id</returns>
        /// <response code="200">**Returns a user**</response>
        [HttpGet("{id}", Name = "GetShopUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<ShopUserDto>>> GetShopUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<ShopUserDto>(user));
        }

        /// <summary>
        /// Register a user
        /// </summary>
        /// <param name="model">**The model for creating user**</param>
        /// <returns>Returns an action result</returns> 
        /// <response code="201">**Returns the user created**</response>
        [HttpPost("register", Name = "RegisterUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [AllowAnonymous]
        public async Task<ActionResult<ShopUserDto>> RegisterUser([FromBody] ShopUserForCreationDto model)
        {
            if (model != null)
            {
                var user = _mapper.Map<ShopUser>(model);

                var result = await _userManager.CreateAsync(user, model.Password);
                  
                if (!result.Succeeded)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.TryAddModelError(error.Code, error.Description);
                    }
                    return UnprocessableEntity(ModelState);
                }

                if (model.Email == "aminuumar26@gmail.com")
                {
                    var roles = new List<string> { "User", "Administrator" };
                    await _userManager.AddToRolesAsync(user, roles);
                }
                else
                {
                    await _userManager.AddToRolesAsync(user, new List<string> { "User" });
                }

                var createdUser = await _userManager.FindByEmailAsync(user.Email);

                var userToReturn = _mapper.Map<ShopUserDto>(createdUser);

                return CreatedAtRoute(nameof(GetShopUser), new {id = createdUser.Id }, userToReturn);

            }
            return UnprocessableEntity(ModelState);            
        }


        /// <summary>
        /// Generate a token for user
        /// </summary>
        /// <param name="userForAuthDto">**Model to generate the token for**</param>
        /// <returns>Returns the token generated</returns>
        /// <response code="201">**Returns a Json Web Token**</response>
        [HttpPost("generatetoken", Name = "GenerateToken")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [AllowAnonymous]
        public async Task<ActionResult<object>> GenerateToken([FromBody] ShopUserForAuthDto userForAuthDto)
        {
            if (!await _shopUserRepository.ValidateUser(userForAuthDto))
            {
                _logger.LogWarning($"{nameof(GenerateToken)}: Authentication failed. Wrong user name or password.");

                return Unauthorized(new { Message = "Either username or password not correct" });
            }

            var tokenOptions = await _shopUserRepository.CreateToken();

            return Created("", new { token = new JwtSecurityTokenHandler().WriteToken(tokenOptions), expires = tokenOptions.ValidTo });
        }



        /// <summary>
        /// Get an order for a User
        /// </summary>
        /// <param name="id">**The id of the Oder**</param>
        /// <param name="orderId">**The id of the User**</param>
        /// <returns>Returns ActionResult of OrderDto</returns>
        /// <response code="200">**Returns a particular Oder for a particular User**</response>
        [HttpGet("{id}/orders/{orderId}", Name = "GetOrderForUser")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [AllowAnonymous]
        public async Task<ActionResult<OrderDto>> GetOrderForUser(Guid id, Guid orderId)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound($"No user exist with id: {id}");
            }

            var orderFromDataStore = await _shopUserRepository.GetOrderForUser(orderId, id);


            if (orderFromDataStore == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<OrderDto>(orderFromDataStore));
        }

        /// <summary>
        /// Create an order for a user
        /// </summary>
        /// <param name="id">**The id of the user to create the order for**</param>
        /// <param name="orderDto">**Model for creating an order**</param>
        /// <returns>Return Action result</returns>
        /// <response code="201">**Returns the created Oder for a particular User**</response>
        [HttpPost("{id}/orders", Name = "CreateOrderForUser")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [AllowAnonymous]
        public async Task<ActionResult<OrderDto>> CreateOrderForUser( Guid id, OrderDto orderDto)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
            {
                return NotFound(new { error = $"No user exist with Id : {id}" });
            }

            if (orderDto == null)
            {
                return UnprocessableEntity(ModelState);
            }

            var order = _mapper.Map<Order>(orderDto);
            await _shopUserRepository.CreateOrderForUser(order);

            var createdOrder = await _shopUserRepository.GetOrderForUser(order.Id, id);

            var orderToReturn = _mapper.Map<OrderDto>(createdOrder);

            return CreatedAtRoute(nameof(GetOrderForUser), new {id=id, orderId = createdOrder.Id}, orderToReturn);
        }
        
        
        /// <summary>
        /// Delete a user by id
        /// </summary> 
        /// <returns>Returns action result</returns>
        /// <response code="204">**The user is successfully deleted**</response>
        [HttpDelete("{id}", Name = "DeleteShopUser")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> DeleteUser(string id)
        {
            var user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound(new { error = $"No user exist with Id : {id}" });
            }

            var identityResult = await _userManager.DeleteAsync(user);
            if (!identityResult.Succeeded)
            {
                return BadRequest(new { error = "Unable to delete user" });
            }
            return NoContent();
        }
 
    }
}
