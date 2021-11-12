using Microsoft.EntityFrameworkCore;

namespace FISharer.Data
{
    public class FilesDbContext : DbContext
    {
        public FilesDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
