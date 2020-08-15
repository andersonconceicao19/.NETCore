using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shop.Context;
using Shop.Models;

namespace Shop.Controllers
{
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly DataContext _context;
        public ProductController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public async Task<ActionResult<List<Product>>> Get()
        {           
            return Ok(await _context.Products
                                    .Include(x => x.Category)
                                    .AsNoTracking()
                                    .ToListAsync()
                                    );
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetbyId(int id)
        {
            var result = await _context.Products.
                                        Include(x=>x.Category)
                                        .AsNoTracking()
                                        .FirstOrDefaultAsync(x => x.Id == id);
            if (result == null) return NotFound();

            return Ok(result);
        }
        [HttpGet("{id:int}")]
        public async Task<ActionResult<List<Product>>> GetbyCategory(int id)
        {
            return Ok(await _context.Products
                                    .Include(x => x.Category)
                                    .AsNoTracking()
                                    .Where(x=> x.CategoryId == id)
                                    .ToListAsync()
                                    );
        }
        public async Task<ActionResult> Post([FromBody] Product model)
        {
            if (!ModelState.IsValid) return BadRequest();
            _context.Products.Add(model);
            await _context.SaveChangesAsync();
            return Ok(model);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] Product model)
        {
            if (!ModelState.IsValid) return BadRequest();
            if (id != model.Id) return NotFound();

            _context.Entry<Product>(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(model);
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(x => x.Id == id);
            if (result == null)
            {
                return NotFound();
            }
            _context.Products.Remove(result);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
