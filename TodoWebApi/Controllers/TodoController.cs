#nullable disable
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;
using TodoWebApi.Models;

namespace TodoWebApi.Controllers
{
    // usare https://localhost:7207/api/todo
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private readonly TodoWebApiContext context;

        public TodoController(TodoWebApiContext context)
        {
            // this. rappresenta questa istanza corrente
            // quindi this.context è la variabile privata che vedo sopra e che viene riusata in vari metodi
            // context senza this davanti, è il parametro ricevuto da chi mi alloca, in questo caso lo ricevo (singleton) dal DI(tecnica dipendency injection ) container
            // il parametro esiste SOLO nelloscope di questo metodo
            this.context = context;
        }

        // GET: api/Todo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Todo>>> GetTodo()
        {
            return await context.Todo.ToListAsync();
        }

        // GET: api/Todo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Todo>> GetTodo(int id)
        {
            var todo = await context.Todo.FindAsync(id);

            if (todo == null)
            {
                return NotFound();
            }

            return todo;
        }

        // PUT: api/Todo/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodo(int id, Todo todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }

            context.Entry(todo).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoExists(id))
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

        // POST: api/Todo
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Todo>> PostTodo(Todo todo)
        {
            context.Todo.Add(todo);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetTodo", new { id = todo.Id }, todo);
        }

        // DELETE: api/Todo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodo(int id)
        {
            var todo = await context.Todo.FindAsync(id);
            if (todo == null)
            {
                return NotFound();
            }

            context.Todo.Remove(todo);
            await context.SaveChangesAsync();

            return NoContent();
        }

        // esempio lambda expr per sapere se esistono todo vecchie
        private bool PendingTodoExists()
        {
            return context.Todo.Any(e => e.State != States.Done && e.CreatedAt.Date < DateTime.Now.Date);
        }

        // esempio di prototipo o bozza di una futura nuova risorsa che esamina tutte le vecchie todo di una certa persona
        public async Task<ActionResult<IEnumerable<Todo>>> GetPendingTodo(string email)
        {
            return await context.Todo.Where(e => e.Profile.Email == email && e.State != States.Done && e.CreatedAt.Date < DateTime.Now.Date).ToListAsync();
        }

        private bool TodoExists(int id)
        {
            return context.Todo.Any(e => e.Id == id);
        }
    }
}
