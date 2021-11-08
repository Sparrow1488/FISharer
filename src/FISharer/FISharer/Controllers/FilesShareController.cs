using FISharer.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading.Tasks;

namespace FISharer.Controllers
{
    
    public class FilesShareController : Controller
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
                {
                    files.ForEach(file => LocalWriteStreamData(file));
                    result = Json(new UploadedFilesViewModel(true, "TOKEN-1488-1337", "Uploaded success"));
                }
                else result = Json(new UploadedFilesViewModel(false, null, "Your status does not allow to upload more than 100MB"));
            }
            return result;
        }
        private void LocalWriteStreamData(IFormFile file)
        {
            using var memoryStream = new MemoryStream();
            file.CopyTo(memoryStream);
            using var archive = new ZipArchive(memoryStream, ZipArchiveMode.Create);
            var entry = archive.CreateEntry(file.Name + ".txt");
            var streamWriter = new StreamWriter(entry.Open());
            streamWriter.Write("BOOBA!!!");
            archive.ExtractToDirectory("C:/Users/aleks/Downloads/myZip.zip", true);


            //using var memoryStream = new MemoryStream();
            //file.CopyTo(memoryStream);
            //using var zip = new ZipArchive(memoryStream, ZipArchiveMode.Create);
            //var entry = zip.CreateEntry(file.FileName);
            //var bytes = memoryStream.ToArray();
            //using var zipWriter = entry.Open();
            //await zipWriter.WriteAsync(bytes, 0, bytes.Length);

            //var compressedBytes = memoryStream.ToArray();
            //using var fs = new FileStream("C:/Users/aleks/Downloads/myZip.zip", FileMode.Create);
            //await fs.WriteAsync(compressedBytes, 0, compressedBytes.Length);
        }
    }
}
