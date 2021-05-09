using System.Collections.Generic;

namespace CQRS_TO_DO.Entity
{
    public class Items {
        public Items(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }

        public string Nome { get; set; }
      public double Valor { get; set; }
    }
}