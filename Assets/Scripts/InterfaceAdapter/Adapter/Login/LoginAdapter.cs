using System;
using UseCase.Login;

namespace InterfaceAdapter.Adapter.Login
{
    public class LoginAdapter
    {
        private ILogin login;

        public event Action<ulong> OnLoginAck
        {
            add
            {
                login.OnLoginAck += value;
            }

            remove
            {
                login.OnLoginAck -= value;
            }
        }

        public LoginAdapter(ILogin login)
        {
            this.login = login;
        }

        public void StartLogin(string ip, ulong playerID)
        {
            login.StartLogin(playerID);
        }
    }
}

