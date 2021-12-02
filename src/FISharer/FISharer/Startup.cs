using FISharer.Data;
using FISharer.Services;
using FISharer.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FISharer
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<ClientsDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<FilesDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IClientsStorageService, ClientsStorageService>();
            services.AddScoped<ICompressionService, ZipCompressionService>();
            services.AddScoped<IFilesStorageService, CompressedFilesStorageService>();
            services.AddScoped<IFilesCleaner, FilesCleaner>();
            services.AddSingleton<IFilesCleanerScheduler, FilesCleanerScheduler>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IFilesCleanerScheduler scheduler)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
