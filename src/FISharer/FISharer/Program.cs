using FISharer.Extensions;
using FISharer.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Quartz;
using System.Linq;
using System.Threading.Tasks;

namespace FISharer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) => 
                services.CreateScheduler<FilesCleaner>(1)) // every minute "0 * * ? * *"
            .ConfigureWebHostDefaults((config) =>
                config.UseStartup<Startup>());
    }
}
