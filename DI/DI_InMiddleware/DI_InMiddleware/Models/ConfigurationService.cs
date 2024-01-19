using DI_InMiddleware.Interface;
using DI_InMiddleware.Models;
using DI_InMiddleware.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class ConfigurationService
    {
        public static IServiceCollection AddAppConfig(this IServiceCollection services,
            IConfiguration Configuration)
        {
            services.Configure<Setting>(Configuration.GetSection("Setting"));
            services.Configure<SettingNetwork>(Configuration.GetSection("Setting"));
            services.Configure<SettingDatabase>(Configuration.GetSection("Setting"));

            return services;
        }
    }

    public static class BusinessService
    {
        public static IServiceCollection AddBusinessService(this IServiceCollection services)
        {
            services.TryAddEnumerable(new ServiceDescriptor[]
            {
                ServiceDescriptor.Scoped<INotificationService, SmsNotificationService>(),
                ServiceDescriptor.Scoped<INotificationService, EmailNotificationService>(),
                ServiceDescriptor.Scoped<INotificationService, SiteNotificationService>(),
                ServiceDescriptor.Scoped<INotificationService, SmsNotificationService>()
            });

            return services;
        }
    }
}
