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
            return $"img_skdev_{DateTimeOffset.Now:dd_MM_yyy_HH_mm_ss}_{Guid.NewGuid()}.jpg";
        }


        public async static Task Savefile(IFormFile formFile, string savePath)
        {          

            using var streamTarget = new FileStream(savePath, FileMode.Create, FileAccess.Write);
            await formFile.CopyToAsync(streamTarget);
        }

        public static bool DeleteFile(string filePath)
        {
            var fileExist = File.Exists(filePath);
             
            if (fileExist)
            {
                File.Delete(filePath);
                return true;
            }

            return false;
        }
    }
}
