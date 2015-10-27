using XSockets.Core.Configuration;

namespace WebHost
{
    public class Configuration : ConfigurationSetting
    {
        public Configuration() : base("ws://127.0.0.1:4502") { }
    }
}
