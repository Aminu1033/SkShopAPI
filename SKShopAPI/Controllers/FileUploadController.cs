using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SKShopAPI.Helpers;
using System.IO;
using System.Threading.Tasks;

namespace SKShopAPI.Controllers
{
    [ApiController]
    [Route("api/uploads")]
    [Produces("application/json", "application/xml")]
    public class FileUploadController : ControllerBase
    {
        public FileUploadController(IWebHostEnvironment env)
        {
            Env = env;
        }

        public IWebHostEnvironment Env { get; }


        /// <summary>
        /// Upload a file
        /// </summary> 
        /// <param name="file">**File to save to the server**</param> 
        /// <returns>Returns the url of the file uploaded</returns> 
        [HttpPost("file", Name = "uploadFile")]
        [ProducesResponseType(StatusCodes.Status422UnprocessableEntity)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null)
            {
                return UnprocessableEntity(new { Error = "You must provide file to upload" });
            }

            var randomName = FileManager.RandomName(); 

            var savePath = Path.Combine(Env.WebRootPath, "img", randomName);

            await FileManager.Savefile(file, savePath);

            var imgUrl = $"https://localhost:5001/img/{randomName}";

            return Created(imgUrl, new { imgUrl, imgName = randomName});
        }


        /// <summary>
        /// Delete a file
        /// </summary>
        /// <param name="fileName">**The file name to delete**</param>
        /// <returns>Returns NoContent</returns>
        /// <response code="204">**Returns NoContent**</response> 
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Policy = "AdminOnly")]
        [HttpDelete("delete")]
        public IActionResult DeleteFile(string fileName)
        {
            if (fileName == null)
            {
                return BadRequest(new {Error = "File name can not be empty or null"});
            }

            var filePath = Path.Combine(Env.WebRootPath, "img", fileName);

            var isDeleted = FileManager.DeleteFile(filePath);
            if (isDeleted)
            {
                return NoContent();
            }

            return NotFound();
        }
    }
}
