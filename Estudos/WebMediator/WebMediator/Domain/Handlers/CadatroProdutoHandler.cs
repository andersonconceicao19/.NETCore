using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Handlers
{
    public class CadatroProdutoHandler : IRequestHandler<RequestProduct, ResponseProduct>
    {
        /**PAROU NO MINUTO 18*/
        public async Task<ResponseProduct> Handle(RequestProduct request, CancellationToken cancellationToken)
        {
            var result = new ResponseProduct
            {
                Id = Guid.NewGuid(),
                Name = "Notebook", 
                Price = 2500,
                Date = DateTime.Now   
            };

            return await Task.FromResult(result);
        }
    }
}
