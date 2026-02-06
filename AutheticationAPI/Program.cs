using AutheticationAPI.Data;
using AutheticationAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer("Server=localhost;Database=IdentityDB; trusted_connection=True; TrustServerCertificate=True;"));
// dotnet user-secrets

builder.Services.AddAuthentication();
builder.Services.AddAuthorization();

builder.Services
    .AddIdentityApiEndpoints<User>()
    .AddEntityFrameworkStores<AppDbContext>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

app.UseSwagger();  
app.UseSwaggerUI();
app.MapSwagger();   

app.MapGet("/", () => "Hello World!");
app.MapIdentityApi<User>();

app.Run();
