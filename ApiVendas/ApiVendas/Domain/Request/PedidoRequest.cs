using ApiVendas.Models;
using System;

namespace ApiVendas.Domain.Request
{
    public class PedidoRequest
    {

        public int Num_Pedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string TipoPedido { get; set; }

        public Guid IdCliente { get; set; }
        public Clientes Cliente { get; set; }
    }
}
