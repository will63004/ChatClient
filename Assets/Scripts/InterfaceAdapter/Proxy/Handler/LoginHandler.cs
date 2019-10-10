using System;
using Protocol;
using Proxy;
using UseCase.Login;

namespace InterfaceAdapter.Proxy.Handler
{
    public class LoginHandler : ILoginHandler, IHandleProtocol
    {
        private ISendProtocol sendProtocol;

        public LoginHandler(ISendProtocol sendProtocol)
        {
            this.sendProtocol = sendProtocol;
        }

        public event Action<ulong> OnLoginAck;

        public void HandleProtocol(byte[] buffer)
        {
            LoginAck ack = LoginAck.Parser.ParseFrom(buffer);
        }

        public void Send(ulong playerID)
        {
            LoginReq req = new LoginReq();
            req.Header = new Header();
            req.Header.ProtoID = ProtoID.ReqLogin;
            req.Header.PlayerID = playerID;
            sendProtocol.SendMessage(req);
        }
    }
}
