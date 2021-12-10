using FISharer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace FISharer.Data
{
    public class ClientsDbContext : IdentityDbContext<Client, ClientRole, Guid>
    {
        public ClientsDbContext([NotNull]DbContextOptions options) : base(options) { }
    }
}
