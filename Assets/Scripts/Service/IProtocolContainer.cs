using Protocol;
using System;

namespace Service
{
    public interface IProtocolContainer
    {
        bool TryGetValue(ProtoID protoID, out Action<byte[]> ack);
    }
}
