using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Handlers
{
    public interface ICadatroProdutoHandler
    {
        ResponseProduct Handler(RequestProduct requestProduct);
    }
}
