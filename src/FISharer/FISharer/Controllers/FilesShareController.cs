using FISharer.Entities;
using FISharer.Models;
using FISharer.Services.Interfaces;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
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

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult Download()
        {
            return View();
        }


        [DisableRequestSizeLimit]
        [HttpPost]
        public async Task<IActionResult> UploadFilesAsync(List<IFormFile> files)
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

        [HttpPost]
        public IActionResult GetFilesInfoAsync(TokenResponseViewModel tokenModel)
        {
            IActionResult response = Json(new { status = "BAD" });
            var context = new ValidationContext(tokenModel);
            var results = new List<ValidationResult>();
            if (Validator.TryValidateObject(tokenModel, context, results))
            {
                var infos = _storage.GetDataInfos(tokenModel.Token).ToList();
                if (infos.Count > 0)
                    response = Json(new { status = "OK", infos });
            }
            return response;
        }

        [HttpPost]
        public async Task<IActionResult> DownloadArchiveAsync(TokenResponseViewModel tokenModel)
        {
            var context = new ValidationContext(tokenModel);
            var results = new List<ValidationResult>();
            var dataResult = new ClientData();
            if (Validator.TryValidateObject(tokenModel, context, results))
                dataResult = await _storage.GetAsync(tokenModel.Token);

            return File(dataResult.CompressedData, "application/force-download", "FISharer-archived-data.zip");
        }

    }
}
