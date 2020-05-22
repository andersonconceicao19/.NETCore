using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required(ErrorMessage = "Preencha o nome")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} caracter")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracter")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o Sobrenome")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} caracter")]
        [MinLength(3, ErrorMessage = "Minimo de {0} caracter")]
        public string Sobrenome { get; set; }

        [Required(ErrorMessage = "Preencha o Email")]
        [MaxLength(100, ErrorMessage = "Maximo de {0} caracter")]
        [EmailAddress(ErrorMessage = "Preencha email valido")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }



    }
}