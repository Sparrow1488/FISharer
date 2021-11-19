using FISharer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FISharer.Data
{
    public class FilesDbContext : DbContext
    {
        public FilesDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<ClientData> Files { get; set; }
        public DbSet<DataInfo> FilesInfos { get; set; }
    }
}