using FISharer.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Quartz;
using System.Threading.Tasks;

namespace FISharer
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                services.AddQuartz(q =>
                {
                    q.UseMicrosoftDependencyInjectionScopedJobFactory();

                    // Create a "key" for the job
                    var jobKey = new JobKey("HelloWorldJob");

                    // Register the job with the DI container
                    q.AddJob<FilesCleaner>(opts => opts.WithIdentity(jobKey));

                    // Create a trigger for the job
                    q.AddTrigger(opts => opts
                        .ForJob(jobKey) // link to the HelloWorldJob
                        .WithIdentity("HelloWorldJob-trigger") // give the trigger a unique name
                        .WithCronSchedule("0 * * ? * *")); // run every 5 seconds

                });
                services.AddQuartzHostedService(q => q.WaitForJobsToComplete = true);
            })
                .ConfigureWebHostDefaults((config) =>
                {
                    config.UseStartup<Startup>();
                });
    }
}
