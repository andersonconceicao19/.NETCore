using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebMediator.Domain.Commands.Request;
using WebMediator.Domain.Commands.Response;

namespace WebMediator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public async Task<ResponseProduct> Cadastro(
            [FromServices] IMediator mediator,
            [FromBody] RequestProduct product)
        {
            return await mediator.Send(product);
        }
    }
}