#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoWebApi.Models;

// usare https://localhost:7207/api/profile
namespace TodoWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly TodoWebApiContext context;

        public ProfileController(TodoWebApiContext context)
        {
            // this. rappresenta questa istanza corrente
            // quindi this.context è la variabile privata che vedo sopra e che viene riusata in vari metodi
            // context senza this davanti, è il parametro ricevuto da chi mi alloca, in questo caso lo ricevo (singleton) dal DI(tecnica dipendency injection ) container
            // il parametro esiste SOLO nelloscope di questo metodo
            this.context = context;
        }

        // GET: api/Profile
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Profile>>> GetPerson()
        {
            return await context.Person.ToListAsync();
        }

        // GET: api/Profile/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Profile>> GetProfile(int id)
        {
            var profile = await context.Person.FindAsync(id);

            if (profile == null)
            {
                return NotFound();
            }

            return profile;
        }

        // PUT: api/Profile/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfile(int id, Profile profile)
        {
            if (id != profile.Id)
            {
                return BadRequest();
            }

            context.Entry(profile).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfileExists(id))
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

        // POST: api/Profile
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Profile>> PostProfile(Profile profile)
        {
            context.Person.Add(profile);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProfile), new { id = profile.Id }, profile);
        }

        // DELETE: api/Profile/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfile(int id)
        {
            var profile = await context.Person.FindAsync(id);
            if (profile == null)
            {
                return NotFound();
            }

            context.Person.Remove(profile);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProfileExists(int id)
        {
            return context.Person.Any(e => e.Id == id);
        }
    }
}
