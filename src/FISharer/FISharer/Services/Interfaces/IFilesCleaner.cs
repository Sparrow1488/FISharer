using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IFilesCleaner
    {
        Task ClearAsync(IFilesStorageService filesStorage);
    }
}
