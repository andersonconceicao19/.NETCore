using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVendas.Models
{
    public class PedidoItens
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
