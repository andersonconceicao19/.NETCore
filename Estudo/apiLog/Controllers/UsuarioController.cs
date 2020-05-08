using System;
using System.Threading.Tasks;
using apilog.Models;
using apilog.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace apilog.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuario _db;
        public UsuarioController(IUsuario db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok();
        }
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {            
            return Ok(_db.GetAll());
        }

        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody]Usuario usuario)
        {
            await _db.Add(usuario);
            return Ok();
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(Guid Id)
        {
            if(Id == null) return BadRequest();
            
            await _db.Remove(Id);
            
            return Ok();
        }
        [HttpPut("{Id}")]
        public async Task<IActionResult> Update(Guid Id, [FromBody]Usuario usuario)
        {
            var user = await _db.GetUserbyId(Id);
            if(user == null) return BadRequest();
            
            user.Email = usuario.Email;
            user.Name = usuario.Name;

           await _db.Update(user);
            return Ok();
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public IActionResult Authenticate([FromBody]Usuario model)
        {
            try
            {
              
                var user = _db.Authenticate(model.Email, model.Password);

                if (user == null)
                    return BadRequest(new { message = "Usuário ou senha inválidos" });

                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}