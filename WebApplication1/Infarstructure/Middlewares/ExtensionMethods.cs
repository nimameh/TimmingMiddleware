namespace WebApplication1.Infarstructure.Middlewares
{
    public static class ExtensionMethods
    {
        static ExtensionMethods()
        {

        }

        public static IApplicationBuilder UseTimeLimit(this IApplicationBuilder app)
        {
            return app.UseMiddleware<TimeMiddleware>();
        }
    }
}

 