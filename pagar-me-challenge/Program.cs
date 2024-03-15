
using Microsoft.EntityFrameworkCore;
using pagar_me_challenge.Application.TransactionEntity.Api;
using pagar_me_challenge.Application.TransactionEntity.Services;
using pagar_me_challenge.Config.IoC;
using pagar_me_challenge.Db.Config;

var builder = WebApplication.CreateBuilder(args);

builder.InversionOfControlInject();
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

app.TransactionApiContext();
app.Run();
