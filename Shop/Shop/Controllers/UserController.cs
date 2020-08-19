using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Context;
using Shop.Models;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly DataContext _context;
        public UserController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("users")]
        [Authorize(Roles = "Gerente")]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Users.AsNoTracking().ToListAsync());
        }
        [HttpPost("")]
        public async Task<ActionResult<User>> Post([FromBody] User model)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Users.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }
        [HttpPost("login")]
        public async Task<ActionResult<dynamic>> Authenticate([FromBody] User model)
        {
            var user = await _context.Users.AsNoTracking()
                                            .Where(x => x.UserName == model.UserName && x.Password == model.Password)
                                            .FirstOrDefaultAsync();
            if (user == null)
            {
                return NotFound();
            }
            var token = TokenService.GenerateToken(user);
            return new
            {
                user = user,
                token = token
            };
        }

       

    }
}
