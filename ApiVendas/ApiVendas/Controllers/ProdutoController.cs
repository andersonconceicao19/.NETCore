using ApiVendas.Domain.Request;
using ApiVendas.Domain.Response;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ApiVendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<ProdutoResponse>> GetAll()
        {
            return Ok("Olá");
        }
        [HttpGet("{id}")]
        public ActionResult<ProdutoResponse> GetById(Guid id)
        {
            return Ok();
        }
        public ActionResult AddCliente([FromBody]ProdutoRequest produtos)
        {
            return Ok();
        }

        [HttpPut()]
        public ActionResult UpdateCliente([FromBody]ProdutoRequest produtos)
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