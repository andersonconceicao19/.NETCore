using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Handlers
{
    public interface ICadatroProdutoHandler
    {
        ResponseProduct Handler(RequestProduct requestProduct);

    }
}
