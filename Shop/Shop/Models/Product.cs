using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MinLength(4, ErrorMessage = "É o valor minimo.")]
        [MaxLength(60, ErrorMessage = "{60} é o valor máximo.")]
        public string Title { get; set; }

        [MaxLength(1254, ErrorMessage = "{60} é o valor máximo.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "O preço deve ser maior que zero.")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
