using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FISharer.Controllers
{
    
    public class FilesShare : Controller
    {
        private static long BYTES_SIZE_OF_100_MB = 104857600;
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> files)
        {
            IActionResult result = BadRequest();
            long summaryLenght = 0;
            if (files != null && files.Count > 0)
            {
                files.ForEach(file => summaryLenght += file.Length);
                if (summaryLenght < BYTES_SIZE_OF_100_MB && summaryLenght > 0)
                    result = Ok();
            }
            return result;
        }
    }
}
