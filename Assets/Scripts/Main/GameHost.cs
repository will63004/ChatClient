using Main;

namespace Main
{
    public class GameHost
    {
        private IGameProcessSystem gameProcessSystem;

        public GameHost(IGameProcessSystem gameProcessSystem)
        {
            this.gameProcessSystem = gameProcessSystem;
        }

        public void Start()
        {
            gameProcessSystem.ChangeProcess(eGameProcess.Login);
        }
    }
}
