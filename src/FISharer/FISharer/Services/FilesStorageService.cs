using FISharer.Data;
using FISharer.Entities;
using FISharer.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FISharer.Services
{
    public class FilesStorageService : IFilesStorageService
    {
        private readonly FilesDbContext _db;

        public FilesStorageService(FilesDbContext db)
        {
            _db = db;
        }

        public Task<string> AddAsync(IEnumerable<IFormFile> formFiles)
        {
            throw new NotImplementedException();
        }

        public async Task<string> AddAsync(byte[] data, IEnumerable<DataInfo> filesInfo)
        {
            string token = GenerateToken();
            var file = new ClientData() { CompressedData = data, CreateTime = DateTime.Now, Token = token };
            file.FilesInfo = filesInfo;
            await _db.Files.AddAsync(file);
            await _db.SaveChangesAsync();
            return token;
        }

        private string GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }

        public async Task<ClientData> GetAsync(string token)
        {
            var data = new ClientData();
            await Task.Run(() => data = Get(token));
            return data;
        }

        public ClientData Get(string token)
        {
            var emptyData = new ClientData();
            var buffered = new ClientData();
            buffered = _db.Files.FirstOrDefault(file => file.Token == token);
            emptyData = buffered ?? emptyData;
            return emptyData;
        }

        public IEnumerable<DataInfo> GetDataInfos(string token)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAllExpiredAsync()
        {
            throw new NotImplementedException();
        }
    }
}
