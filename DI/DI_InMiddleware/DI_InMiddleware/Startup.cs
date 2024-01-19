using DI_InMiddleware.Interface;
using DI_InMiddleware.Middlewares;
using DI_InMiddleware.Models;
using DI_InMiddleware.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI_InMiddleware
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

            services.AddAppConfig(Configuration)
                .AddBusinessService();


            //services.TryAddEnumerable(ServiceDescriptor.Scoped<INotificationService, EmailNotificationService>());
            //services.TryAddEnumerable(ServiceDescriptor.Scoped<INotificationService, SmsNotificationService>());
            //services.TryAddEnumerable(ServiceDescriptor.Scoped<INotificationService, SiteNotificationService>());
            //services.TryAddEnumerable(ServiceDescriptor.Scoped<INotificationService, SmsNotificationService>());


            //services.TryAddScoped<INotificationService, SiteNotificationService>();
            //services.Replace(ServiceDescriptor.Scoped<INotificationService, SmsNotificationService>());
            //services.RemoveAll<INotificationService>();


            //Factory
            services.AddScoped<IuploadServer>(p =>
            {
                string ip = Configuration.GetSection("Ip").Value;
                string username = Configuration.GetSection("UserName").Value;
                string password = Configuration.GetSection("Password").Value;
                return new UploadToServer(ip, username, password, "");
            });

            services.AddScoped<TelegramShare>();
            services.AddScoped<InstagramShare>();

            services.AddScoped<IShareService>(p =>
            {
                string shareValue = Configuration.GetSection("Share").Value;

                if (shareValue == "Telegram")
                {
                    return new TelegramShare();
                }
                else
                {
                    return new InstagramShare();
                }
            });

            services.AddScoped<IProductRepository, ProductRepository>();

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
            app.UseTestMiddleware();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
