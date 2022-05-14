using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SKShopAPI.Helpers
{
    public class FileManager
    { 
        public static string RandomName()
        {
            return $"img_skdev_{DateTimeOffset.Now:dd_MM_yyy_HH_mm_ss}.jpg";
        }


        public async static Task Savefile(IFormFile formFile, string randomName)
        {
            IWebHostEnvironment env = null;
            var savePath = Path.Combine(env.WebRootPath, "img", randomName);

            using var streamTarget = new FileStream(savePath, FileMode.Create, FileAccess.Write);
            await formFile.CopyToAsync(streamTarget);
        }
    }
}
