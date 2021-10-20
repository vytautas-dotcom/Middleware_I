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
        public static IApplicationBuilder UseMyContextItem(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyContextItemMiddleware>();
        }
        public static IApplicationBuilder UseMyCookiesMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MyCookiesMiddleware>();
        }

        public static List<IApplicationBuilder> UseMyMiddlewares(this IApplicationBuilder builder)
        {
            List<IApplicationBuilder> FirstFolder = new List<IApplicationBuilder>();

            FirstFolder.Add(builder.UseMiddleware<MyErrorHandlingMiddleware>());
            FirstFolder.Add(builder.UseMiddleware<MyContextItemMiddleware>());
            FirstFolder.Add(builder.UseMiddleware<MyCookiesMiddleware>());
            FirstFolder.Add(builder.UseMiddleware<MyAutheticationMiddleware>());
            FirstFolder.Add(builder.UseMiddleware<MyRoutingMiddleware>());

            return FirstFolder;
        }
    }
}
