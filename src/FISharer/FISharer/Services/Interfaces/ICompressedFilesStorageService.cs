using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface ICompressedFilesStorageService : IFilesStorageService
    {
        Task<string> AddUseCompressAsync(IEnumerable<IFormFile> files);
    }
}
