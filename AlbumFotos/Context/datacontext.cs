using AlbumFotos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.Context
{
    public class datacontext: DbContext
    {
        public datacontext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Album> Albuns { get; set; }
        public DbSet<Imagem> Imagens { get; set; }
    }
}
