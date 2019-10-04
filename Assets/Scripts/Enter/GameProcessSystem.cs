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
        private IUISystem uiSystem;

        private GameProcessContext context;
                
        public GameProcessSystem(IGameSetting gameSetting, ISceneSystem sceneSystem, IUISystem uiSystem)
        {
            this.gameSetting = gameSetting;
            this.sceneSystem = sceneSystem;
            this.uiSystem = uiSystem;
            context = new GameProcessContext();
        }

        public void ChangeProcess(eGameProcess process)
        {
            context.PreGameProcess = context.GameProcess;
            context.GameProcess = process;

            //GameSetting.Start();
            AsyncOperation sceneOperation = sceneSystem.ChangeState(eScene.Login);
            sceneOperation.completed += onSceneLoadDone;
            AsyncOperation uiOperation = uiSystem.ChangeState(eUIState.Login);
            uiOperation.completed += onUILoadDone;
        }
        private void onSceneLoadDone(AsyncOperation obj)
        {
            Debug.Log("onSceneLoadDone");
            obj.completed -= onSceneLoadDone;
        }
        private void onUILoadDone(AsyncOperation obj)
        {
            Debug.Log("onUILoadDone");
            obj.completed -= onUILoadDone;
        }        
    }
}
