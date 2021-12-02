using FISharer.Services.Interfaces;
using Quartz;
using System.Threading.Tasks;

namespace FISharer.Services
{
    [DisallowConcurrentExecution]
    public class FilesCleaner : IFilesCleaner, IJob
    {
        public FilesCleaner(IFilesStorageService filesStorage)
        {
            _filesStorage = filesStorage;
        }

        private readonly IFilesStorageService _filesStorage;

        public async Task ClearAsync()
        {
            await Task.Run(() =>
            {
                var deletedFiles = _filesStorage.DeleteAllExpiredAsync();
            });
        }

        public async Task Execute(IJobExecutionContext context) =>
            await ClearAsync();
    }
}
