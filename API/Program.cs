using API.Extensions;
using API.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//Extension AddApplicationServices (Connetion String DB)
builder.Services.AddApplicationServices(builder.Configuration);
//Extension AddIdentityServices (Authentication Service)
builder.Services.AddIdentityServices(builder.Configuration);


var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
 