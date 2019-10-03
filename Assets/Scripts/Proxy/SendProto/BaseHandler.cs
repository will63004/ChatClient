using Grpc.Core;

namespace Proxy.SendProto
{
    public class BaseHandler
    {
        protected Channel channel;

        public BaseHandler(Channel channel)
        {
            this.channel = channel;
        }
    }
}
