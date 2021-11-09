using FISharer.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IClientsStorageService
    {
        Task CreateAsync(Client client);
        List<Client> GetAll();
    }
}
