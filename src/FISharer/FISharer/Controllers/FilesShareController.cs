using FISharer.Data;
using FISharer.Entities;
using FISharer.Services.Interfaces;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Threading.Tasks;

namespace FISharer.Controllers
{
    
    public class FilesShareController : Controller
    {
        public FilesShareController(IClientsStorageService storage)
        {
            _storage = storage;
        }

        private const long BYTES_SIZE_OF_100_MB = 104857600;
        private readonly IClientsStorageService _storage;

        public async Task<IActionResult> Index()
        {
            await _storage.CreateAsync(new Client() { Name = "Test", Password = "1234" });
            var all = _storage.GetAll();
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
                {
                    var dataPath = SaveDataLocalRange(files);
                    CompressDirectory(dataPath);
                    result = Json(new UploadedFilesViewModel(true, "TOKEN-1488-1337", "Uploaded success"));
                }
                else result = Json(new UploadedFilesViewModel(false, null, "Your status does not allow to upload more than 100MB"));
            }
            return result;
        }

        private string SaveDataLocalRange(IEnumerable<IFormFile> files)
        {
            string dirPath = Path.GetFullPath("./transient-data");
            if(!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            foreach (var file in files)
            {
                using var bufferStream = new MemoryStream();
                file.CopyTo(bufferStream);
                var fileBytes = bufferStream.ToArray();
                System.IO.File.WriteAllBytes(Path.Combine(dirPath, file.FileName), fileBytes);
            }
            return dirPath;
        }

        private void CompressDirectory(string dirPath)
        {
            var root = Path.GetDirectoryName(dirPath);
            ZipFile.CreateFromDirectory(dirPath, Path.Combine(root, "compressed.zip"));
        }

    }
}
