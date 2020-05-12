using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Domain.Commands.Request
{
    public class RequestProduct : IRequest<ResponseProduct>
    {
        /*
         * É necessário installar o package do MediatR para poder usá-lo
         * Declarar as propriedades que irá ser usada quando for fazer a requisição
         */
        public string Name { get; set; }
        public decimal Price { get; set; }




        /**         
         * 
         * A classe que vamos utilizar para mandar os parâmetros para API
         
         */
    }
}
