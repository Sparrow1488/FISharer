using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IFilesStorageService
    {
        Task<string> AddAsync(byte[] data);
        byte[] Get(string token);
        Task<byte[]> GetAsync(string token);
    }
}
