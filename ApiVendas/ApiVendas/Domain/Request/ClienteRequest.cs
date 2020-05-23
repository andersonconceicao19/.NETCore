using System;

namespace ApiVendas.Domain.Request
{
    public class ClienteRequest
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
