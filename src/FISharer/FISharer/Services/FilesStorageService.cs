using FISharer.Data;
using FISharer.Services.Interfaces;
using System;

namespace FISharer.Services
{
    public class FilesStorageService : IFilesStorageService
    {
        //private readonly FilesDbContext _db;

        //public FilesStorageService(FilesDbContext db)
        //{
        //    _db = db;
        //}

        public string Add(byte[] data)
        {
            throw new NotImplementedException();
        }

        public byte[] Get(string token)
        {
            throw new NotImplementedException();
        }
    }
}
