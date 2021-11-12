using FISharer.Entities;
using Microsoft.EntityFrameworkCore;

namespace FISharer.Data
{
    public class ClientDbContext : DbContext
    {
        public ClientDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Client> Clients { get; set; }
    }
}
