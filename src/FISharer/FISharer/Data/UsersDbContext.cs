using FISharer.Entities.Clients;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace FISharer.Data
{
    public class UsersDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public UsersDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
