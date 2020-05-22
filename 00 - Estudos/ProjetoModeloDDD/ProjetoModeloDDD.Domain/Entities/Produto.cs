using System;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto : Entity
    {
        
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public bool Disponivel { get; set; }

        public Guid ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
