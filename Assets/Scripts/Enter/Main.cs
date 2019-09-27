namespace Game.Main
{
    public class Main:IMain
    {       
        private IGameProcessSystem GameProcessSystem { get; set; }

        public Main(IGameProcessSystem gameProcessSystem)
        {
            GameProcessSystem = gameProcessSystem;
        }

        public void Start() 
        {
            GameProcessSystem.ChangeProcess(eGameProcess.Login);
        }
    }
}
