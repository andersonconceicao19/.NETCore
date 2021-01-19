using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class DBContextSQLServer : DbContext
    {
        public DBContextSQLServer(DbContextOptions<DBContextSQLServer> op) : base(op)
        {

        }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DBContextSQLServer).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
