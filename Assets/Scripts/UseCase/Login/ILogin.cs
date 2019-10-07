using System;

namespace UseCase.Login
{
    public interface ILogin
    {
        event Action<ulong> OnLoginAck;

        void StartLogin(ulong playerID);
    }
}
