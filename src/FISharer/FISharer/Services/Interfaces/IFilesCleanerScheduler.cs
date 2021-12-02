using System.Threading.Tasks;

namespace FISharer.Services.Interfaces
{
    public interface IFilesCleanerScheduler
    {
        Task StartAsync();
    }
}
