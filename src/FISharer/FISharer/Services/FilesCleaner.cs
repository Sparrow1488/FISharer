using FISharer.Services.Interfaces;
using Quartz;
using System.Threading.Tasks;

namespace FISharer.Services
{
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
    }
}
