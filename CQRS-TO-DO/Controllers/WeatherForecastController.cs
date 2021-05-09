using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS_TO_DO.Domain;
using CQRS_TO_DO.Domain.Queries;
using CQRS_TO_DO.Entity;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CQRS_TO_DO.Controllers
{
    [ApiController]
    [Route("api")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator Mediator)
        {
            _mediator = Mediator;
        }

        [HttpGet]
        public ActionResult<List<Object>> Get()
        {
            var result = _mediator.Send(new GetItemsQuery());
            
            return Ok(result);
        }
        [HttpPost]
        public ActionResult Post([FromBody]AddItemsInputCommand aic)
        {
            var it = new AddItemsCommand(aic.Nome, aic.Valor);            
            _mediator.Send(it);
            return Ok();
        }
    }
}
