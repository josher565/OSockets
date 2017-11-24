using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(OSockets.Startup1))]

namespace OSockets
{
    public class Startup1 {
        public void Configuration(IAppBuilder app)
        {
            // New code:
            app.Run(context =>
            {
                context.Response.ContentType = "text/plain";
                return context.Response.WriteAsync("Hello, world.");
            });
        }
    }
}