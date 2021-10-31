namespace RoboSum.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RoboSum.API.Models;
    using static RoboSum.API.Constants;

    [Route($"{Api}/{CurrentVersion}/[controller]")]
    [ApiController]
    public class CompetitionsController : ControllerBase
    {
        private readonly RoboSumContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetitionsController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public CompetitionsController(RoboSumContext context)
        {
            _context = context;
        }

        // GET: api/Competitions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Competitions>>> GetCompetitions()
        {
            return await _context.Competitions.ToListAsync();
        }

        // GET: api/Competitions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Competitions>> GetCompetitions(int id)
        {
            var competitions = await _context.Competitions.FindAsync(id);

            if (competitions == null)
            {
                return NotFound();
            }

            return competitions;
        }

        // PUT: api/Competitions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompetitions(int id, Competitions competitions)
        {
            if (id != competitions.Id)
            {
                return BadRequest();
            }

            _context.Entry(competitions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompetitionsExists(id))
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

        // POST: api/Competitions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Competitions>> PostCompetitions(Competitions competitions)
        {
            _context.Competitions.Add(competitions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCompetitions", new { id = competitions.Id }, competitions);
        }

        // DELETE: api/Competitions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompetitions(int id)
        {
            var competitions = await _context.Competitions.FindAsync(id);
            if (competitions == null)
            {
                return NotFound();
            }

            _context.Competitions.Remove(competitions);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CompetitionsExists(int id)
        {
            return _context.Competitions.Any(e => e.Id == id);
        }
    }
}
