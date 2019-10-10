using Google.Protobuf;

namespace Proxy
{
    public interface ISendProtocol
    {
        void SendMessage(IMessage message);
    }
}
