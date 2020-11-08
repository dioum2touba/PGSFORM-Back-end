using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PGSFORM.Models;

namespace PGSFORM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencielsController : ControllerBase
    {
        private readonly PgsformContext _context;

        public ReferencielsController(PgsformContext context)
        {
            _context = context;
        }

        // GET: api/Referenciels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Referenciel>>> GetReferenciel()
        {
            return await _context.Referenciel.ToListAsync();
        }

        // GET: api/Referenciels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Referenciel>> GetReferenciel(int id)
        {
            var referenciel = await _context.Referenciel.FindAsync(id);

            if (referenciel == null)
            {
                return NotFound();
            }

            return referenciel;
        }

        // PUT: api/Referenciels/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReferenciel(int id, Referenciel referenciel)
        {
            if (id != referenciel.Id)
            {
                return BadRequest();
            }

            _context.Entry(referenciel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReferencielExists(id))
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

        // POST: api/Referenciels
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Referenciel>> PostReferenciel(Referenciel referenciel)
        {
            _context.Referenciel.Add(referenciel);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReferenciel", new { id = referenciel.Id }, referenciel);
        }

        // DELETE: api/Referenciels/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Referenciel>> DeleteReferenciel(int id)
        {
            var referenciel = await _context.Referenciel.FindAsync(id);
            if (referenciel == null)
            {
                return NotFound();
            }

            _context.Referenciel.Remove(referenciel);
            await _context.SaveChangesAsync();

            return referenciel;
        }

        private bool ReferencielExists(int id)
        {
            return _context.Referenciel.Any(e => e.Id == id);
        }
    }
}
