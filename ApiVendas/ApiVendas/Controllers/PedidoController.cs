using ApiVendas.Domain.Request;
using ApiVendas.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<PedidoResponse>> GetAll()
        {

            return Ok("Olá");
        }

        [HttpGet("{Num_Pedido}")]
        public ActionResult<PedidoResponse> GetById(int Num_Pedido)
        {
            return Ok();
        }
        public ActionResult AddCliente([FromBody]PedidoRequest pedidos)
        {
            return Ok();
        }

        [HttpPut()]
        public ActionResult UpdateCliente([FromBody]PedidoRequest pedidos)
        {
            return Ok();
        }

        [HttpDelete("{Num_Pedido}")]
        public ActionResult DeleteCliente(Guid id)
        {
            return Ok();
        }

    }
}