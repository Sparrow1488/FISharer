using FISharer.Services.Interfaces;
using FISharer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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
                    var dataPath = SaveDataLocalRange(files);
                    var compressedData = CompressDirectoryToBytes(dataPath);
                    var token = await _storage.AddAsync(compressedData);

                    result = Json(new UploadedFilesViewModel(true, token, "Uploaded success"));
                }
                else result = Json(new UploadedFilesViewModel(false, string.Empty, "Your status does not allow to upload more than 100MB"));
            }
            return result;
        }

        private string SaveDataLocalRange(IEnumerable<IFormFile> files)
        {
            string dirPath = Path.GetFullPath("./transient-data-" + new Random().Next(12300, 999999999));
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

        private byte[] CompressDirectoryToBytes(string dirPath)
        {
            var root = Path.GetDirectoryName(dirPath);
            var zipPath = Path.Combine(root, "compressed-" + new Random().Next(199999, 99999999) + ".zip");
            ZipFile.CreateFromDirectory(dirPath, zipPath);
            var data = System.IO.File.ReadAllBytes(zipPath);

            Directory.Delete(dirPath, true);
            System.IO.File.Delete(zipPath);

            return data;
        }

    }
}
