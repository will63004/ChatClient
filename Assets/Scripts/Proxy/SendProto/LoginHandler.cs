using System;
using Grpc.Core;
using Protocol;
using UseCase.Login;

namespace Proxy.SendProto
{
    public class LoginHandler : BaseHandler,ILoginHandler
    {
        private EchoLogin.EchoLoginClient echo;

        public LoginHandler(Channel channel) : base(channel)
        {
            echo = new EchoLogin.EchoLoginClient(channel);
        }

        public event Action<ulong> OnLoginAck;

        public async void Send(ulong playerID)
        {
            Header header = new Header();
            header.PlayerID = playerID;                        
            LoginAck ack = await echo.LoginAsync(new LoginReq { Header = header });
            OnLoginAck?.Invoke(ack.Header.PlayerID);
        }
    }
}
