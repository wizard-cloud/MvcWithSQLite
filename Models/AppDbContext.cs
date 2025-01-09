using Microsoft.EntityFrameworkCore;
using MvcWithSQLite.Models;



namespace MvcWithSQLite.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario>? Usuarios { get; set; }
    }
}


