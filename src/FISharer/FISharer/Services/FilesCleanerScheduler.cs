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
                    .WithIntervalInSeconds(5)
                    .RepeatForever())
                .Build();

            await scheduler.ScheduleJob(job, trigger);
        }
    }
}
