using ApiVendas.Models;
using System;
using System.Collections.Generic;

namespace ApiVendas.Domain.Request
{
    public class ProdutoRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public decimal Valor { get; set; }

        public Produtos Produto { get; set; }
        public List<PedidoItens> Itens { get; set; }
    }
}
