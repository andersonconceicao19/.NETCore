using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Preencha o nome do produto")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} caracter")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracter")]
        public string Nome { get; set; }
        
        [MaxLength(300, ErrorMessage = "Maximo de {0} caracter")]
        [MinLength(0 , ErrorMessage = "Minimo de {0} caracter")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Preencha um valor")]
        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "99999")]
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }

        public Guid ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}