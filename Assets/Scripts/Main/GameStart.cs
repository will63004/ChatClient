using UnityEngine;
using Game.Database;
using Game.Scene;
using Game.Main;
using Game.Database.UnityScriptableObject;
using Game.UI;
using Service;

public class GameStart : MonoBehaviour
{
    void Start()
    { 
        string ip = "127.0.0.1";
        int port = 3000;
        Client m_client = new Client(ip, port);
        m_client.Start();

        IProtocolContainer protocolContainer = new ProtocolContainer();
        ProtocolParser protocolParser = new ProtocolParser(m_client, protocolContainer);

        IScriptableObjectLoader scriptableObjectLoader = new ScriptableObjectLoader();
        ISceneTable sceneTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.SceneTable) as ISceneTable;
        ISceneSystem sceneSystem = new SceneSystem(sceneTable);
        IGameSetting gameSetting = new GameSetting();
        IUIPrefabTable uiPrefabTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.UISystemTable) as IUIPrefabTable;
        IUILoader uiLoader = new UILoader(uiPrefabTable);
        IUISystem uiSystem = new UISystem(uiLoader);
        IGameProcessSystem gameProcessSystem = new GameProcessSystem(gameSetting, sceneSystem, uiSystem);
        IGameMainLoop gameMainLoop = new GameMainLoop(gameProcessSystem);
        gameMainLoop.Start();

        DontDestroyOnLoad(this);
    }
}
