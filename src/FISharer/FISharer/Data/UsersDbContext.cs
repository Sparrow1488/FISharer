using FISharer.Entities.Clients;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics.CodeAnalysis;

namespace FISharer.Data
{
    public class UsersDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public UsersDbContext([NotNull]DbContextOptions<UsersDbContext> options) : base(options) { }
    }
}
