using FISharer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FISharer.Data
{
    public class FilesDbContext : DbContext
    {
        public FilesDbContext([NotNull] DbContextOptions options) : base(options) { }
        public DbSet<ClientData> Files { get; set; }
    }
}
