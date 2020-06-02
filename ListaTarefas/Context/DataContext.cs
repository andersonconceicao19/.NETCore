using ListaTarefas.Models;
using Microsoft.EntityFrameworkCore;


namespace ListaTarefas.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {    }
        public DbSet<Tarefas> Tarefas { get; set; }
    }
}
