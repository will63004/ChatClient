using Protocol;
using Proxy;
using UseCase.HeartBeat;
using UseCase.Player;

namespace InterfaceAdapter.Proxy.Handler
{
    public class HeartBeatHandler : ISendHeartBeat, IHandleProtocol
    {
        private ISendProtocol sendProtocol;
        private IPlayer player;

        public HeartBeatHandler(ISendProtocol sendProtocol, IPlayer player)
        {
            this.sendProtocol = sendProtocol;
            this.player = player;
        }

        public void HandleProtocol(byte[] buffer)
        {
            HeartBeatAck ack = HeartBeatAck.Parser.ParseFrom(buffer);
        }

        public void Send()
        {
            HeartBeatReq req = new HeartBeatReq();
            req.Header = new Header();
            req.Header.ProtoID = ProtoID.ReqHeartBeat;
            req.Header.PlayerID = 1;
            sendProtocol.SendMessage(req);
        }
    }
}
