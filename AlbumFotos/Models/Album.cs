using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlbumFotos.Models
{
    public class Album
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage ="Campo obrigatório"), MaxLength(50, ErrorMessage = "Use menos caracter")]
        public string Destino { get; set; }


      
        public string  FotoTopo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Inicio { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Fim { get; set; }
        public ICollection<Imagem> Imagem { get; set; }
    }
}
