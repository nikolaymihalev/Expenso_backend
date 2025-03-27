using Expenso.Infrastructure.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Expenso.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {            
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
