using System;

namespace ApiVendas.Domain.Request
{
    public class PedidoItemRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
    }
}
