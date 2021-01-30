using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using kidsGardenApi.Models;

namespace kidsGardenApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstitucionController : ControllerBase
    {
        private readonly kidsGardenContext _context;

        public InstitucionController(kidsGardenContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Institucion>>> GetInstitucions()
        {
            return await _context.Institucions.Include( x => x.UsuarioPorInstitucions ).ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Institucion>> GetInstitucion(int id)
        {
            var institucion = await _context.Institucions.FindAsync(id);

            if (institucion == null)
            {
                return NotFound();
            }

            return institucion;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstitucion(int id, Institucion institucion)
        {
            if (id != institucion.IdInstitucion)
            {
                return BadRequest();
            }

            _context.Entry(institucion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstitucionExists(id))
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

        [HttpPost]
        public async Task<ActionResult<Institucion>> PostInstitucion(Institucion institucion)
        {
            _context.Institucions.Add(institucion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstitucion", new { id = institucion.IdInstitucion }, institucion);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Institucion>> DeleteInstitucion(int id)
        {
            var institucion = await _context.Institucions.FindAsync(id);
            if (institucion == null)
            {
                return NotFound();
            }

            _context.Institucions.Remove(institucion);
            await _context.SaveChangesAsync();

            return institucion;
        }

        private bool InstitucionExists(int id)
        {
            return _context.Institucions.Any(e => e.IdInstitucion == id);
        }
    }
}
