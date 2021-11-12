using FISharer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace FISharer.Data
{
    public class ClientsDbContext : DbContext
    {
        public ClientsDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
    }
}
