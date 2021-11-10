using FISharer.Data;
using FISharer.Entities;
using FISharer.Services.Interfaces;
using System;
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

        public byte[] Get(string token)
        {
            throw new NotImplementedException();
        }

        public async Task<string> AddAsync(byte[] data)
        {
            string token = GenerateToken();
            var file = new ClientData() { CompressedData = data, CreateTime = DateTime.Now, Token = token };
            await _db.Files.AddAsync(file);
            await _db.SaveChangesAsync();
            return token;
        }

        private string GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }

        public Task<byte[]> GetAsync(string token)
        {
            throw new NotImplementedException();
        }
    }
}
