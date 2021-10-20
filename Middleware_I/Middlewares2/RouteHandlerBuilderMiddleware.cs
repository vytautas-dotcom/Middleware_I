using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Threading.Tasks;

namespace Middleware_I.Middlewares2
{
    public static class RouteHandlerBuilderMiddleware
    {
        public static IApplicationBuilder BuildRoute(this IApplicationBuilder app)
        {
            var routeHandler = new RouteHandler(Handler);
            var routeBuilder = new RouteBuilder(app, routeHandler);

            routeBuilder.MapRoute("default", "{controller}/{action}/{id?}");

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("Goes through RouteHandlerBuilderMiddleware. Enter index or about plus token to go further.");
                await next.Invoke();
            });

            return app.UseRouter(routeBuilder.Build());
        }
        private static async Task Handler(HttpContext context)
        {
            await context.Response.WriteAsync("From RouteHandlerBuilder");
        }
    }
}
