using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class ResponseEditMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseEditMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {

            await _next(httpContext);

            if (httpContext.Response.StatusCode == 404)
                await httpContext.Response.WriteAsync("page not founf !");
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ResponseEditMiddlewareExtensions
    {
        public static IApplicationBuilder UseResponseEditMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ResponseEditMiddleware>();
        }
    }
}
