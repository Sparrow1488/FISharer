using FISharer.Services.Interfaces;
using Quartz;
using Quartz.Impl;
using System.Threading.Tasks;

namespace FISharer.Services
{
    public class FilesCleanerScheduler : IFilesCleanerScheduler
    {
        public async Task StartAsync()
        {
            IScheduler scheduler = await StdSchedulerFactory.GetDefaultScheduler();
            await scheduler.Start();

            IJobDetail job = JobBuilder.Create<FilesCleaner>().Build();

            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("FilesCleanerScheduler", "FilesSchedulers")
                .StartNow()
                .WithSimpleSchedule(x => x
<<<<<<< HEAD
                    .WithIntervalInSeconds(5)
=======
                    .WithIntervalInSeconds(1)
>>>>>>> 63f120dcbfcca49bb7b54bf817805e9c09cc8506
                    .RepeatForever())
                .Build();

            await scheduler.ScheduleJob(job, trigger);
        }
    }
}
