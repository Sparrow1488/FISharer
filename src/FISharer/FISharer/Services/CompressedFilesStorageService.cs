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
    public class CompressedFilesStorageService : ICompressedFilesStorageService
    {
        private readonly FilesDbContext _db;
        private readonly ICompressionService _compressor;

        public CompressedFilesStorageService(FilesDbContext db, ICompressionService compressor)
        {
            _db = db;
            _compressor = compressor;
        }

        public async Task<string> AddAsync(byte[] data)
        {
            string token = GenerateToken();
            var file = new ClientData() { CompressedData = data, CreateTime = DateTime.Now, Token = token };
            await _db.Files.AddAsync(file);
            await _db.SaveChangesAsync();
            return token;
        }

        public async Task<string> AddAsync(IEnumerable<IFormFile> formFiles)
        {
            return await AddUseCompressAsync(formFiles);
        }

        public async Task<string> AddUseCompressAsync(IEnumerable<IFormFile> files)
        {
            var compressedData = _compressor.Compress(files);
            var token = await AddAsync(compressedData);
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

    }
}
