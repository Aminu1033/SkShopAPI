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
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null)
            {
                return UnprocessableEntity(new { Error = "You must provide file to upload" });
            }

            var randomName = FileManager.RandomName(); 

            var savePath = Path.Combine(Env.WebRootPath, "img", randomName);

            await FileManager.Savefile(file, randomName, savePath);

            var imgUrl = $"https://localhost:5001/img/{randomName}";

            return Ok(new { imgUrl = imgUrl});
        }
    }
}
