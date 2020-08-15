using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "O campo é requerido.")]
        [MinLength(4, ErrorMessage = "É o valor minimo.")]
        [MaxLength(60, ErrorMessage = "{60} é o valor máximo.")]
        public string Title { get; set; }
    }
}
