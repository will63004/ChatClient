using System;
using Game.Database;
using Game.Scene;
using InterfaceAdapter.Adapter.Login;
using Main.UIImplement;
using UISystem;
using UnityEngine;

namespace Main
{
    public class GameProcessSystem :IGameProcessSystem
    {
        private IGameSetting gameSetting;
        private ISceneSystem sceneSystem;
        private IUIController uiController;
        private LoginAdapter loginAdapter;

        private GameProcessContext context;
                
        public GameProcessSystem(IGameSetting gameSetting, ISceneSystem sceneSystem, IUIController uiController, LoginAdapter loginAdapter)
        {
            this.gameSetting = gameSetting;
            this.sceneSystem = sceneSystem;
            this.uiController = uiController;
            this.loginAdapter = loginAdapter;
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
                    uiController.OpenUI((int)eUIImplement.Login);
                    loginAdapter.OnLoginAck += onLoginAck;
                    break;
            }
        }

        private void onLoginAck(ulong playerID)
        {
            uiController.CloseUI((int)eUIImplement.Login);
            loginAdapter.OnLoginAck -= onLoginAck;
        }

        private void onSceneLoadDone(AsyncOperation obj)
        {
            Debug.Log("onSceneLoadDone");
            obj.completed -= onSceneLoadDone;
        }
    }
}
