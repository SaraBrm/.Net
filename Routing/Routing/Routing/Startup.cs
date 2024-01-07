using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Routing
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
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}" );

                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "about",
                    defaults: new { Controller = "Home", action = "About" });

                endpoints.MapControllerRoute(
                    name: "blog2",
                    pattern: "blog",
                    defaults: new { Controller = "Product", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "blog",
                    pattern: "blog",
                    defaults: new { Controller = "Blog", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "detail",
                    pattern: "blog/{category}/{url}",
                    defaults: new { Controller = "Blog", action = "Detail" });


                endpoints.MapControllerRoute(
                    name: "product",
                    pattern: "product/{*index}",
                    defaults: new { Controller = "Product", action = "Index" });


                endpoints.MapControllerRoute(
                     name: "default",
                     pattern: "{controller=Home}/{action=Index}/{id?}/{name?}");

            });
        }
    }
}
