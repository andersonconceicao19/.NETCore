using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class DBContextMySQL : DbContext
    {
        public DBContextMySQL(DbContextOptions<DBContextMySQL> op) : base(op)
        {

        }
        public DbSet<Usuario> tbUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().HasNoKey();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContextMySQL).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
