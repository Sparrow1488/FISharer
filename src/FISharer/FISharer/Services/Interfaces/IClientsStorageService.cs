using FISharer.Entities;
using FISharer.Entities.Clients;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IClientsStorageService
    {
        Task CreateAsync(User client);
        List<User> GetAll();
    }
}
