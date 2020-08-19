using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Context;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    [Route("v1/categories")]
    public class CategoryController : ControllerBase
    {
        private readonly DataContext _context;
        public CategoryController(DataContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public async Task<ActionResult<List<Category>>> Get()
        {
            return Ok(await _context.Categories.AsNoTracking().ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetbyId(int id)
        {
            var result = await _context.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return NotFound();            

            return Ok(result);
        }

        [HttpPost("")]
        public async Task<ActionResult> Post([FromBody]Category model)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Categories.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody]Category model)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (id != model.Id) return NotFound();

            _context.Entry<Category>(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _context.Categories.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            _context.Categories.Remove(result);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
