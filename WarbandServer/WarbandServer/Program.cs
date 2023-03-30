using Microsoft.EntityFrameworkCore;
using WarbandServer.Repositories;
using WarbandServer.Repositories.Interfaces;
using WarbandServer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// TODO move this to safe
builder.Services.AddDbContext<WarbandContext>(options => options.UseNpgsql(
    @"Server=PostgreSQL 12;Host=localhost;Port=5432;Username=postgres;Password=root;Database=warband"));
builder.Services.AddScoped<IWarbandRepository, WarbandRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUnitRepository, UnitRepository>();
builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<IFactionRepository, FactionRepository>();


builder.Services.AddControllers();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
