using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloMvcApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Without a call to AddControllersAsServices, this project
            // requires ("preserveCompilationContext": true) 
            services.AddMvcCore()
                    .AddJsonFormatters()
                    .AddControllersAsServices(typeof(Startup).GetTypeInfo().Assembly);
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(LogLevel.Debug);

            app.UseIISPlatformHandler();
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseMvc();
        }
    }
}