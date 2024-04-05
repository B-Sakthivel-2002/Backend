using Microsoft.EntityFrameworkCore;
using task.Context;
using task.Crud;
using task.Interface;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<myContext>(options=>options.UseSqlServer(
        builder.Configuration.GetConnectionString("Conn"))  
    );
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<myInterface, taskcrud>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.MapControllers();

app.Run();
