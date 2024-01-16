using DI_InMiddleware.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace DI_InMiddleware.Middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class TestMiddleware
    {
        private readonly RequestDelegate _next;
        //private readonly INotificationService _notificationService;
        public TestMiddleware(RequestDelegate next  /*,INotificationService notificationService*/)
        {
            //_notificationService = notificationService;
            _next = next;
        }

        public Task Invoke(HttpContext httpContext, INotificationService notificationService)
        {
            notificationService.Send("hi .....", 85475);
            return _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class TestMiddlewareExtensions
    {
        public static IApplicationBuilder UseTestMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TestMiddleware>();
        }
    }
}
