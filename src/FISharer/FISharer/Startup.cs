using FISharer.Data;
using FISharer.Entities;
using FISharer.Entities.Clients;
using FISharer.Services;
using FISharer.Services.Interfaces;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

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
            services.AddDbContext<FilesDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContext<UsersDbContext>(config => config.UseSqlServer(Configuration.GetConnectionString("ClientsConnection")))
                .AddIdentity<User, UserRole>(config =>
                {
                    config.Password.RequireDigit = false;
                    config.Password.RequireLowercase = false;
                    config.Password.RequireUppercase = false;
                    config.Password.RequiredLength = 3;
                    config.Password.RequireNonAlphanumeric = false;
                })
            .AddEntityFrameworkStores<UsersDbContext>();

            services.AddAuthorization(options =>
            {
                string user = "User";
                string admin = "Admin";
                options.AddPolicy(user, builder => builder.RequireClaim(ClaimTypes.Role, user));
                options.AddPolicy(admin, builder => 
                    builder.RequireAssertion(handler =>
                        handler.User.HasClaim(ClaimTypes.Role, user) ||
                        handler.User.HasClaim(ClaimTypes.Role, admin)));
            });

            services.ConfigureApplicationCookie(config =>
            {
                config.LoginPath = "/Home/Login";
                config.AccessDeniedPath = "/Home/AccessDenied";
            });

            services.AddScoped<IClientsStorageService, ClientsStorageService>();
            services.AddScoped<ICompressionService, ZipCompressionService>();
            services.AddScoped<IFilesStorageService, CompressedFilesStorageService>();
            services.AddScoped<IFilesCleaner, FilesCleaner>();
            services.AddSingleton<IFilesCleanerScheduler, FilesCleanerScheduler>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IFilesCleanerScheduler scheduler)
        {
            scheduler.StartAsync().GetAwaiter().GetResult();
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
