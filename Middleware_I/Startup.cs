using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Middleware_I.Extensions;
using Middleware_I.Middlewares2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Middleware_I
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.BuildRoute();

            app.UseMyMiddlewares();

            
        }
    }
}
