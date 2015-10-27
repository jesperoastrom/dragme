using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using XSockets.Owin.Host;

[assembly: OwinStartup(typeof(WebHost.Startup))]

namespace WebHost
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureStaticFiles(app);
            ConfigureXSockets(app);
        }

        private static void ConfigureXSockets(IAppBuilder app)
        {
            app.UseXSockets(new OwinHostConfiguration
            {
                WithInterceptors = true,
                WithXSocketsEndpoint = true
            });
        }

        private static void ConfigureStaticFiles(IAppBuilder app)
        {
            var physicalFileSystem = new PhysicalFileSystem(@".\wwwroot");
            var options = new FileServerOptions
            {
                EnableDefaultFiles = true,
                FileSystem = physicalFileSystem
            };
            options.StaticFileOptions.FileSystem = physicalFileSystem;
            options.StaticFileOptions.ServeUnknownFileTypes = true;
            options.DefaultFilesOptions.DefaultFileNames = new[] { "index.html" };
            app.UseFileServer(options);
        }
    }
}
