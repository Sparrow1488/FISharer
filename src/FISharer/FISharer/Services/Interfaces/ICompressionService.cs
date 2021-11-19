using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace FISharer.Services.Interfaces
{
    public interface ICompressionService
    {
        byte[] Compress(string directoryPath);
        byte[] Compress(IEnumerable<IFormFile> files);
    }
}
