namespace Game.Main
{
    public class GameMainLoop:IGameMainLoop
    {       
        private IGameProcessSystem GameProcessSystem { get; set; }

        public GameMainLoop(IGameProcessSystem gameProcessSystem)
        {
            GameProcessSystem = gameProcessSystem;
        }

        public void Start() 
        {
            GameProcessSystem.ChangeProcess(eGameProcess.Login);
        }
    }
}
