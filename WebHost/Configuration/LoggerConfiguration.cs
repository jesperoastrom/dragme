using System.IO;
using Serilog;
using XSockets.Logger;

namespace WebHost.Configuration
{
    public class LoggerConfiguration : XLogger
    {
        public LoggerConfiguration()
        {
            Log.Logger = new Serilog.LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo.ColoredConsole()
                //.WriteTo.RollingFile(Path.Combine(Directory.GetCurrentDirectory(), "Log\\Log-{Date}.txt"))
                .WriteTo.Trace()
                .CreateLogger();
        }
    }
}
