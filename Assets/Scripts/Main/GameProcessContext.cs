namespace Game.Main
{
    public class GameProcessContext
    {
        public eGameProcess PreGameProcess { get; set; }
        public eGameProcess GameProcess { get; set; }

        public GameProcessContext()
        {
            PreGameProcess = eGameProcess.None;
            GameProcess = eGameProcess.None;
        }
    }
}
