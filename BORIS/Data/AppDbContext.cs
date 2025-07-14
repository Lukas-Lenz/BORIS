using BORIS.Models;
using Microsoft.EntityFrameworkCore;

namespace BORIS.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }

        public DbSet<ContactViewModel> Contacts { get; set; }
    }
}
