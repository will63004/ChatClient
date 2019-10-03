
using System;

namespace UseCase.Login
{
    public interface ILoginHandler
    {
        void Send(ulong playerID);

        event Action<ulong> OnLoginAck;
    }
}
