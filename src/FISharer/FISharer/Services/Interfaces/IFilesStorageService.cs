using FISharer.Entities;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IFilesStorageService
    {
        Task<string> AddAsync(byte[] data, IEnumerable<DataInfo> dataInfos);
        Task<string> AddAsync(IEnumerable<IFormFile> formFiles);
        Task<ClientData> GetAsync(string token);
        ClientData Get(string token);
        IEnumerable<DataInfo> GetDataInfos(string token);
        int DeleteAllExpired();
    }
}
