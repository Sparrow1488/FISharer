using Microsoft.Extensions.DependencyInjection;
using Quartz;

namespace FISharer.Extensions
{
    public static class QuartzConfigurateExtenion
    {
        public static void CreateScheduler<TContext>(this IServiceCollection services, int minuteInterval) where TContext : IJob
        {
            services.AddQuartz(q =>
            {
                q.UseMicrosoftDependencyInjectionScopedJobFactory();

                string scedulerName = typeof(TContext).Name;
                var jobKey = new JobKey(scedulerName);

                q.AddJob<TContext>(opts => opts.WithIdentity(jobKey));

                q.AddTrigger(opts => opts
                    .ForJob(jobKey)
                    .WithIdentity($"{scedulerName}-trigger")
                    .WithDailyTimeIntervalSchedule((scheduler) =>
                    {
                        scheduler.OnEveryDay().WithIntervalInMinutes(minuteInterval).Build();
                    }));

            });
            services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
        }
    }
}
