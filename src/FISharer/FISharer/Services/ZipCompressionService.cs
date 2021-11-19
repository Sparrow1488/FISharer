using FISharer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;

namespace FISharer.Services
{
    public class ZipCompressionService : ICompressionService
    {
        public byte[] Compress(string directoryPath)
        {
            var root = Path.GetDirectoryName(directoryPath);
            var zipPath = Path.Combine(root, "compressed-" + new Random().Next(199999, 99999999) + ".zip");
            ZipFile.CreateFromDirectory(directoryPath, zipPath);
            var data = File.ReadAllBytes(zipPath);

            Directory.Delete(directoryPath, true);
            File.Delete(zipPath);

            return data;
        }

        public byte[] Compress(IEnumerable<IFormFile> files)
        {
            var localPath = SaveDataLocalRange(files);
            return Compress(localPath);
        }

        private string SaveDataLocalRange(IEnumerable<IFormFile> files)
        {
            string dirPath = Path.GetFullPath("./transient-data-" + new Random().Next(12300, 999999999));
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            foreach (var file in files)
            {
                using var bufferStream = new MemoryStream();
                file.CopyTo(bufferStream);
                var fileBytes = bufferStream.ToArray();
                File.WriteAllBytes(Path.Combine(dirPath, file.FileName), fileBytes);
            }
            return dirPath;
        }

    }
}
