using ApiVendas.Domain.Request;
using ApiVendas.Domain.Response;
using ApiVendas.Models;

namespace ApiVendas.Mapper
{
    public class ClienteMapper
    {
        public static Clientes Mapper(ClienteRequest clienteRequest)
        {
            return new Clientes
            {
                Id = clienteRequest.Id,
                DataNascimento = clienteRequest.DataNascimento,
                Email = clienteRequest.Email,
                Nome = clienteRequest.Nome
            };
        }
        public static ClienteResponse Mapper(Clientes cliente)
        {
            return new ClienteResponse
            {
                Id = cliente.Id.ToString(),
                DataNascimento = cliente.DataNascimento.ToString(),
                Email = cliente.Email,
                Nome = cliente.Nome
            };
        }
    }
}
