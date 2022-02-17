// progetto ottenuto con il comando:
// dotnet new webapi
// ricordarsi di eseguire il seguente comando nel terminale
// dotnet dev-certs https --trust
// nel terminale
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// uso in memory
//builder.Services.AddDbContext<TodoWebApiContext>(opt =>
//    opt.UseInMemoryDatabase("InMemoryDbTodo"));

// uso sqlserver
string connectionString = builder.Configuration.GetConnectionString("DbTodo");
builder.Services.AddDbContext<TodoWebApiContext>(opt =>
                                 opt.UseSqlServer(connectionString));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else if (app.Environment.IsProduction() || app.Environment.IsStaging())
{
     app.UseDeveloperExceptionPage();
}
else
{
     app.UseDeveloperExceptionPage();
    throw new Exception("Attenzione: Environment non è configurato correttamente");
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
