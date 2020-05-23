using ApiVendas.Domain.Request;
using ApiVendas.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<ClienteResponse>> GetAll()
        {

            return Ok();
        }
        [HttpGet("{id}")]
        public ActionResult<ClienteResponse> GetById(Guid id)
        {
            return Ok();
        }
        [HttpPost]
        public ActionResult AddCliente([FromBody]ClienteRequest clientes)
        {
            return Ok();
        }

        [HttpPut()]
        public ActionResult UpdateCliente([FromBody]ClienteRequest clientes)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteCliente(Guid id)
        {
            return Ok();
        }

    }
}