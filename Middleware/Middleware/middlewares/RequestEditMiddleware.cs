﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware.middlewares
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class RequestEditMiddleware
    {
        private readonly RequestDelegate _next;

        public RequestEditMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            httpContext.Items["IsChromeBrowser"] = httpContext.Request.Headers["User-Agent"].Any(x => x.ToLower().Contains("chrome")); 
            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class RequestEditMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestEditMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestEditMiddleware>();
        }
    }
}
