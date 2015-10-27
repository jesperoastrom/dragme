using XSockets.Core.Configuration;

namespace WebHost.Configuration
{
    public class XSocketServerConfiguration : ConfigurationSetting
    {
        public XSocketServerConfiguration() : base("ws://127.0.0.1:4502") { }
    }
}
