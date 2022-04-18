using Microsoft.Extensions.Options;
using WebApplication1.Infarstructure.Settings;

namespace WebApplication1.Infarstructure.Middlewares
{
    public class TimeMiddleware : object
    {
        
        public TimeMiddleware(RequestDelegate next, IConfiguration configuration) : base()
        {
            Next = next;
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        public RequestDelegate Next { get; set; }
        public async Task InvokeAsync(HttpContext httpContext)
        {
            //var startTime = TimeSpan.Parse("12:00");
            var currentTime = DateTime.Now.TimeOfDay;
            var startTime = TimeSpan.Parse(Configuration.GetSection(key: "Timming:StartTime").Value);
            var endTime = TimeSpan.Parse(Configuration.GetSection(key: "Timming:EndTime").Value);
            if (currentTime < startTime || currentTime > endTime)
            {
                await httpContext.Response.WriteAsync("out of Time!");
                return;
            }

            await Next(httpContext);
        }
    }
}
