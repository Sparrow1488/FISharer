using FISharer.Services.Interfaces;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FISharer.Controllers
{

    public class FilesShareController : Controller
    {
        public FilesShareController(IFilesStorageService storage)
        {
            _storage = storage;
        }

        private const long BYTES_SIZE_OF_100_MB = 104857600;
        private readonly IFilesStorageService _storage;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download()
        {
            return View();
        }

        [DisableRequestSizeLimit]
        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            IActionResult result = Json(new UploadedFilesViewModel(false, string.Empty, "Files data equals null or empty"));
            long summaryLenght = 0;
            if (files != null && files.Count > 0)
            {
                files.ForEach(file => summaryLenght += file.Length);
                if (summaryLenght < BYTES_SIZE_OF_100_MB && summaryLenght > 0)
                {
                    var token = await _storage.AddAsync(files);
                    result = Json(new UploadedFilesViewModel(true, token, "Uploaded success"));
                }
                else result = Json(new UploadedFilesViewModel(false, string.Empty, "Your status does not allow to upload more than 100MB"));
            }
            return result;
        }

    }
}
