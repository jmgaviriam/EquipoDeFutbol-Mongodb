using Adaptador.Mongo;
using Adaptador.Mongo.Interfaces;
using Adaptador.Mongo.Repositorios;
using Api.Mongo.AutoMapper;
using AutoMapper.Data;
using Mongo.CasoDeUso.CasosDeUso;
using Mongo.CasoDeUso.ViasDeAcceso;
using Mongo.CasoDeUso.ViasDeAcceso.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(config => config.AddDataReaderMapping(), typeof(ConfigurationProfile));
builder.Services.AddSingleton<IContext>(provider =>
    new Context(builder.Configuration.GetConnectionString("DefaultConnection"), "test"));

builder.Services.AddScoped<IEntrenadorCasoDeUso, EntrenadorCasoDeUso>();
builder.Services.AddScoped<IRepositorioEntrenador, RepositorioEntrenador>();

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