using System;
using System.Collections.Generic;

namespace ApiVendas.Models
{
    public class Produtos
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal Valor { get; set; }

        public Produtos Produto { get; set; }
        public List<PedidoItens> Itens { get; set; }
    }
}
