using XSockets.Core.Common.Interceptor;
using XSockets.Core.Common.Protocol;

namespace WebHost.Pipeline
{
    public class ConnectionInterceptor : IConnectionInterceptor
    {

        public void Connected(IXSocketProtocol protocol)
        {

        }

        public void Disconnected(IXSocketProtocol protocol)
        {

        }

        public void HandshakeCompleted(IXSocketProtocol protocol)
        {

        }

        public void HandshakeInvalid(string rawHandshake)
        {

        }
    }
}
