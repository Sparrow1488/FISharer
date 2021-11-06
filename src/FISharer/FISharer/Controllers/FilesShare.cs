using FISharer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace FISharer.Controllers
{
    
    public class FilesShare : Controller
    {
        private const long BYTES_SIZE_OF_100_MB = 104857600;
        public IActionResult Index()
        {
            return View();
        }

        [DisableRequestSizeLimit]
        [HttpPost]
        public IActionResult UploadFiles(List<IFormFile> files)
        {
            IActionResult result = Json(new UploadedFilesViewModel(false, null, "Files data equals null or empty"));
            long summaryLenght = 0;
            if (files != null && files.Count > 0)
            {
                files.ForEach(file => summaryLenght += file.Length);
                if (summaryLenght < BYTES_SIZE_OF_100_MB && summaryLenght > 0)
                    result = Json(new UploadedFilesViewModel(true, "TOKEN-1488-1337", "Uploaded success"));
                else result = Json(new UploadedFilesViewModel(false, null, "Your status does not allow to upload more than 100MB"));
            }
            return result;
        }
    }
}
