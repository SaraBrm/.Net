using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Middleware.middlewares;
using System.Net.Http;
using System.Threading.Tasks;

namespace Middleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            //app.UseUserInfo();

            app.UseRouting();
            app.UseRequestEditMiddleware();
            app.UseRequestEditMiddleware();
            app.UseCircuitMiddleware();
            app.UseContentMiddleware();

            //app.Run(mdl);
        }

        private async Task mdl(HttpContext context)
        {
            await context.Response.WriteAsync("Hiii.....");
        }
    }
}
