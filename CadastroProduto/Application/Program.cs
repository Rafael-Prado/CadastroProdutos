using Application.AutoMapper;
using Domain.Repositories;
using Domain.Servicies;
using Domain.Servicies.Interface;
using Domain.Validator;
using Infra.Context;
using Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ProdutoContext>(
                options => options.UseSqlServer(@"Server=0.0.0.0;Database=Produto;User ID=sa;Password=131823Wotoro@;Trusted_Connection=True;"));

builder.Services.AddScoped<ProdutoContext, ProdutoContext>();
builder.Services.AddScoped<ProdutoStoreContext, ProdutoStoreContext>();
builder.Services.AddTransient<ProdutoValidator, ProdutoValidator>();

//Service
builder.Services.AddTransient<IProdutoService, ProdutoService>();

//Repository
builder.Services.AddTransient<IProdutoRepository, ProdutoRepository>();

builder.Services.AddAutoMapper(typeof(ConfigurationMapping));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
