using System;
using UseCase.Player;

namespace UseCase.Login
{
    public class Login: ILogin
    {
        private IPlayer player;

        private ILoginHandler loginHandler;

        public event Action<ulong> OnLoginAck;

        public Login(IPlayer player, ILoginHandler loginHandler)
        {
            this.player = player;
            this.loginHandler = loginHandler;

            loginHandler.OnLoginAck += onLoginAck;
        }

        ~Login()
        {
            loginHandler.OnLoginAck -= onLoginAck;
        }

        public void StartLogin(ulong playerID)
        {
            loginHandler.Send(playerID);
        }

        private void onLoginAck(ulong playerID)
        {
            player.SetPlayerID(playerID);

            OnLoginAck?.Invoke(playerID);
        }
    }
}
