using FISharer.Services.Interfaces;
using Quartz;
using System.Threading.Tasks;

namespace FISharer.Services
{
<<<<<<< HEAD
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
=======
    public class FilesCleaner : IFilesCleaner, IJob
    {
        //public FilesCleaner(IFilesStorageService filesStorage)
        //{
        //    _filesStorage = filesStorage;
        //}

        //private readonly IFilesStorageService _filesStorage;

        public async Task ClearAsync(IFilesStorageService filesStorage)
        {
            await Task.Run(() =>
            {
                var deletedFiles = filesStorage.DeleteAllExpired();
            });
        }

        public async Task Execute(IJobExecutionContext context)
        {
            await ClearAsync(null);
        }
>>>>>>> 63f120dcbfcca49bb7b54bf817805e9c09cc8506
    }
}
