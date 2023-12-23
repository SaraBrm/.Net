using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Middleware.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class UserInfo
    {
        private readonly RequestDelegate _next;

        public UserInfo(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var userInfo = httpContext.Request.Headers["User-Agent"];
            string ip = httpContext.Connection.RemoteIpAddress.ToString();

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class UserInfoExtensions
    {
        public static IApplicationBuilder UseUserInfo(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<UserInfo>();
        }
    }
}
