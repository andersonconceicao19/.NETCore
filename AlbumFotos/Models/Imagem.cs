using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.Models
{
    public class Imagem
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Link { get; set; }
        public Guid AlbumId { get; set; }
        public Album Albums { get; set; }
    }
}
