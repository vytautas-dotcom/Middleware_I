using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares
{
    public class MyAutheticationMiddleware
    {
        private readonly RequestDelegate _next;
        public MyAutheticationMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            if (string.IsNullOrWhiteSpace(context.Request.Query["token"]))
            {
                context.Response.StatusCode = 403;
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
