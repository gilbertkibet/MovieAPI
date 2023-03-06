using CleanMovie.Application;
using CleanMovie.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Register configuration
ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

//Add db connection

builder.Services.AddDbContext<MovieDbContext>(options =>
options.UseSqlServer(configuration.GetConnectionString("MovieConnection"),b=>
b.MigrationsAssembly("CleanMovie.API")));

builder.Services.AddScoped<IMovieService, MovieService > ();

builder.Services.AddScoped<IMovieRepository, MovieRepository> ();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}
    app.UseSwaggerUI();

    app.UseSwagger();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
