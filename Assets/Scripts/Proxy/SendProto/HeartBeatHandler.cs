using Grpc.Core;
using Protocol;
using UnityEngine;
using UseCase.HeartBeat;

namespace Proxy.SendProto
{
    public class HeartBeatHandler : ISendHeartBeat
    {
        private Channel channel;

        private EchoHeartBeat.EchoHeartBeatClient echo;

        public HeartBeatHandler(Channel channel)
        {
            this.channel = channel;

            echo = new EchoHeartBeat.EchoHeartBeatClient(channel);               
        }

        public void Send()
        {            
            Header header = new Header();
            header.PlayerID = 1;
            var reply = echo.HeartBeat(new  HeartBeatReq { Header = header});
            Debug.Log("HeartBeatAck");
        }
    }
}
