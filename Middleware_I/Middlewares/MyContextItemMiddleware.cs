using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares
{
    public class MyContextItemMiddleware
    {
        private readonly RequestDelegate _next;

        public MyContextItemMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);

            context.Items.Add("Error404", "Not Found");
            context.Items.Add("Error403", "Access Denied");

        }
    }
}
