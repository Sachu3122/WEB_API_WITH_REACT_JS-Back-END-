using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FinalDraft.Model;

namespace FinalDraft.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainsController : ControllerBase
    {
        private readonly SachuDbContext _context;

        public MainsController(SachuDbContext context)
        {
            _context = context;
        }

        // GET: api/Mains
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Main>>> GetMains()
        {
            return await _context.Mains.ToListAsync();
        }

        // GET: api/Mains/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Main>> GetMain(int id)
        {
            var main = await _context.Mains.FindAsync(id);

            if (main == null)
            {
                return NotFound();
            }

            return main;
        }

        // PUT: api/Mains/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMain(int id, Main main)
        {
            if (id != main.Id)
            {
                return BadRequest();
            }

            _context.Entry(main).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MainExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Mains
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Main>> PostMain(Main main)
        {
            _context.Mains.Add(main);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMain", new { id = main.Id }, main);
        }

        // DELETE: api/Mains/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMain(int id)
        {
            var main = await _context.Mains.FindAsync(id);
            if (main == null)
            {
                return NotFound();
            }

            _context.Mains.Remove(main);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MainExists(int id)
        {
            return _context.Mains.Any(e => e.Id == id);
        }
    }
}
