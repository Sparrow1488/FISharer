using FISharer.Data;
using FISharer.Entities;
using FISharer.Services.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FISharer.Services
{
    public class ClientsStorageService : IClientsStorageService
    {
        private readonly ClientsDbContext _db;

        public ClientsStorageService(ClientsDbContext db)
        {
            _db = db;
        }
        public async Task CreateAsync(Client client)
        {
            await _db.AddAsync(client);
            await _db.SaveChangesAsync();
        }

        public List<Client> GetAll()
        {
            var list = _db.Clients.ToList();
            return list;
        }
    }
}
