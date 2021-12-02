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

        public async Task<string> AddAsync(byte[] data, IEnumerable<DataInfo> filesInfo)
        {
            string token = GenerateToken();
            var file = new ClientData() { CompressedData = data, CreateTime = DateTime.Now, Token = token };
            file.FilesInfo = filesInfo;
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
            var filesInfos = GetDataInfos(files);
            var token = await AddAsync(compressedData, filesInfos);
            return token;
        }

        private IEnumerable<DataInfo> GetDataInfos(IEnumerable<IFormFile> files)
        {
            var listInfos = new List<DataInfo>();
            foreach (var file in files)
            {
                var info = new DataInfo();
                info.Name = file.FileName;
                info.Size = file.Length;
                listInfos.Add(info);
            }
            return listInfos;
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
            var emptyInfo = new DataInfo();
            var findArchive = _db.Files.Where(arch => arch.Token == token).FirstOrDefault();
            IEnumerable<DataInfo> findInfos = _db.FilesInfos.Where(info => info.ArchiveData == findArchive).ToList();
            foreach (var info in findInfos)
                info.ArchiveData = null;
            return findInfos ?? new List<DataInfo>();
        }

        public async Task<int> DeleteAllExpiredAsync()
        {
            int removedCount = 0;
            var ex = DateTime.Now - TimeSpan.FromMinutes(20);
            var expiredFiles = _db.Files.Where(file => file.CreateTime <= ex);
            if (expiredFiles != null)
            {
                foreach (var item in expiredFiles)
                {
                    var file = _db.Files.Remove(item);
                }
                var success = _db.SaveChanges();
                removedCount = expiredFiles.Count();
            }
            return removedCount;
        }

        private bool CheckTime(DateTime time)
        {
            var subs = DateTime.Now - time;
            var b = subs >= TimeSpan.FromMinutes(20);
            return b;
        }
    }
}
