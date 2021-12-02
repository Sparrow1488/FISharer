using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IFilesCleaner
    {
<<<<<<< HEAD
        Task ClearAsync();
=======
        Task ClearAsync(IFilesStorageService filesStorage);
>>>>>>> 63f120dcbfcca49bb7b54bf817805e9c09cc8506
    }
}
