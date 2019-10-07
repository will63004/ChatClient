using Game.Player;
using System;

namespace UseCase.Login
{
    public class Login: ILogin
    {
        private Player player;

        private ILoginHandler loginHandler;

        public event Action<ulong> OnLoginAck;

        public Login(Player player, ILoginHandler loginHandler)
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
            player.PlayerID = playerID;

            OnLoginAck?.Invoke(playerID);
        }
    }
}
