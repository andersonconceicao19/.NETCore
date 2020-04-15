using apilog.Models;
using Microsoft.EntityFrameworkCore;

namespace apilog.Data
{
     public class MyContext : DbContext {
        public MyContext (DbContextOptions<MyContext> options) : base (options) { }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.ApplyConfigurationsFromAssembly(typeof(MyContext).Assembly);           
           base.OnModelCreating(modelBuilder);
        }
    }
}