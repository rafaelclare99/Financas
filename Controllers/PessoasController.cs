using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Teste.Models;
using Teste.Data;

namespace Teste.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PessoasController(AppDbContext context)
        {
            _context = context;
        }

        // Função  GET
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> Get()
        {
            return await _context.Pessoas.ToListAsync();
        }

        // Função  POST 
        [HttpPost]
        public async Task<ActionResult<Pessoa>> Post(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new { id = pessoa.Id }, pessoa);
        }

        // Função  PUT  
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Pessoa pessoa)
        {
            if (id != pessoa.Id)
                return BadRequest("Id da URL diferente do corpo da requisição.");

            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Pessoas.Any(p => p.Id == id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // Função Delete Pessoas 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
                return NotFound();

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
