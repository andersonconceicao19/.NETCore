using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MinLength(3, ErrorMessage = "É o valor minimo.")]
        [MaxLength(20, ErrorMessage = "{60} é o valor máximo.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "O campo é requerido.")]
        [MinLength(3, ErrorMessage = "É o valor minimo.")]
        [MaxLength(20, ErrorMessage = "{60} é o valor máximo.")]
        public string Password { get; set; }

        public string Role { get; set; }


    }
}
