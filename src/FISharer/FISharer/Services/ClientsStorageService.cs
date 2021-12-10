using FISharer.Data;
using FISharer.Entities;
using FISharer.Entities.Clients;
using FISharer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FISharer.Services
{
    public class ClientsStorageService : IClientsStorageService
    {
        //private readonly ClientsDbContext _db;

        public ClientsStorageService()
        {
            //_db = db;
        }
        public async Task CreateAsync(User client)
        {
            //await _db.AddAsync(client);
            //await _db.SaveChangesAsync();
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            //var list = _db.Clients.ToList();
            //return list;
            throw new NotImplementedException();
        }
    }
}
