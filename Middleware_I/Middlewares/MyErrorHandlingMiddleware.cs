﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares
{
    public class MyErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public MyErrorHandlingMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            await _next.Invoke(context);

            if (context.Response.StatusCode == 403)
            {
                await context.Response.WriteAsync("Access denied");
            }
            else if (context.Response.StatusCode == 404)
            {
                await context.Response.WriteAsync("Not found");
            }
        }
    }
}
