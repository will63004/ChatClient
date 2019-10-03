using Game.Player;

namespace UseCase.Login
{
    public class Login: ILogin
    {
        private Player player;

        private ILoginHandler loginHandler;

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
        }
    }
}
