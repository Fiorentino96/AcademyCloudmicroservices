using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TodoWebApi.Models;

namespace TodoApi.Models
{
    public class TodoWebApiContext : DbContext
    {// Server=tcp:sqlsrvtodoapi.database.windows.net,1433;Initial Catalog=TodoWebApiContext;Persist Security Info=False;User ID=daniele;Password=MyDbPassword!123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;

        public TodoWebApiContext(DbContextOptions<TodoWebApiContext> options)
            : base(options)
        {
        }

        public DbSet<Todo> Todo { get; set; } = null!;
        public DbSet<Profile> Person { get; set; } = null!;
    }
}