using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares
{
    public class MyCookiesMiddleware
    {
        private readonly RequestDelegate _next;

        public MyCookiesMiddleware(RequestDelegate next) => _next = next;

        public async Task Invoke(HttpContext context)
        {
            string name;
            if (context.Request.Cookies.TryGetValue("name", out name))
            {
                context.Items.Add("name", name);
            }
            else
            {
                context.Response.Cookies.Append("name", "John");
            }
            await _next.Invoke(context);
        }
    }
}
