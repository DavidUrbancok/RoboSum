namespace RoboSum.API.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using RoboSum.Models;
    using static RoboSum.API.Constants;

    [Route($"{Api}/{CurrentVersion}/[controller]")]
    [ApiController]
    public class RefereesController : ControllerBase
    {
        private readonly RoboSumContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefereesController"/> class.
        /// </summary>
        /// <param name="context">The database context.</param>
        public RefereesController(RoboSumContext context)
        {
            _context = context;
        }

        // GET: api/Referees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Referee>>> GetReferees()
        {
            return await _context.Referees.ToListAsync();
        }

        // GET: api/Referees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Referee>> GetReferee(int id)
        {
            var referee = await _context.Referees.FindAsync(id);

            if (referee == null)
            {
                return NotFound();
            }

            return referee;
        }

        // PUT: api/Referees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReferee(int id, Referee referee)
        {
            if (id != referee.Id)
            {
                return BadRequest();
            }

            _context.Entry(referee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RefereeExists(id))
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

        // POST: api/Referees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Referee>> PostReferee(Referee referee)
        {
            _context.Referees.Add(referee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetReferee", new { id = referee.Id }, referee);
        }

        // DELETE: api/Referees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReferee(int id)
        {
            var referee = await _context.Referees.FindAsync(id);
            if (referee == null)
            {
                return NotFound();
            }

            _context.Referees.Remove(referee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool RefereeExists(int id)
        {
            return _context.Referees.Any(e => e.Id == id);
        }
    }
}
