using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Models
{
    public class Pedidos
    {
        public int Num_Pedido { get; set; }
        public DateTime DataPedido { get; set; }
        public string TipoPedido { get; set; }

        public Guid IdCliente { get; set; }
        public Clientes Cliente { get; set; }
    }
}
