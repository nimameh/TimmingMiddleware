using WebApplication1.Infarstructure.Middlewares;
using WebApplication1.Infarstructure.Settings;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();
builder.Services.AddHttpContextAccessor();
var configuration = builder.Configuration;
builder.Services.Configure<AppSettings>(configuration.GetSection("AppSettings"));

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

//app.UseMiddleware<WebApplication1.Middlewares.TimeMiddleware>();
app.UseTimeLimit();
app.MapControllers();
app.Run();

