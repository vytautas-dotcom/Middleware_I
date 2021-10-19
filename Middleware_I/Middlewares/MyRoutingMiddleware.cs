using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares
{
    public class MyRoutingMiddleware
    {
        private readonly RequestDelegate _next;
        public MyRoutingMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Path.Value.ToLower() == "/index")
            {
                await context.Response.WriteAsync("This is the Index Page");
            }
            else if(context.Request.Path.Value.ToLower() == "/about")
            {
                await context.Response.WriteAsync("This is the About Page");
            }
            else
            {
                context.Response.StatusCode = 404;
            }
        }
    }
}
