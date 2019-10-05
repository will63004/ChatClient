using Game.Database;
using Game.Scene;
using UISystem;
using UnityEngine;

namespace Game.Main
{
    public class GameProcessSystem :IGameProcessSystem
    {
        private IGameSetting gameSetting;
        private ISceneSystem sceneSystem;
        private IUIController uiController;

        private GameProcessContext context;
                
        public GameProcessSystem(IGameSetting gameSetting, ISceneSystem sceneSystem, IUIController uiController)
        {
            this.gameSetting = gameSetting;
            this.sceneSystem = sceneSystem;
            this.uiController = uiController;
            context = new GameProcessContext();
        }

        public void ChangeProcess(eGameProcess process)
        {
            context.PreGameProcess = context.GameProcess;
            context.GameProcess = process;

            //GameSetting.Start();
            AsyncOperation sceneOperation = sceneSystem.ChangeState(eScene.Login);
            sceneOperation.completed += onSceneLoadDone;

            switch (process)
            {
                case eGameProcess.Login:
                    uiController.OpenUI(1);
                    break;
            }
        }
        private void onSceneLoadDone(AsyncOperation obj)
        {
            Debug.Log("onSceneLoadDone");
            obj.completed -= onSceneLoadDone;
        }
    }
}
