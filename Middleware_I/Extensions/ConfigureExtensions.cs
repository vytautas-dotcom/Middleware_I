using Microsoft.AspNetCore.Builder;
using Middleware_I.Middlewares;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I.Extensions
{
    public static class ConfigureExtensions
    {
        public static IApplicationBuilder UseMyAuthentication(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyAutheticationMiddleware>();
        }
        public static IApplicationBuilder UseMyRouting(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyRoutingMiddleware>();
        }
        public static IApplicationBuilder UseMyErrorHandling(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyErrorHandlingMiddleware>();
        }
    }
}
