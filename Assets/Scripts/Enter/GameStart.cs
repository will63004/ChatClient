using UnityEngine;
using Game.Database;
using Game.Scene;
using Game.Main;
using Game.Database.UnityScriptableObject;
using Game.UI;
using Game.HeartBeat;
using Grpc.Core;
using TcpService.Service;
using ProtoService.ProtoBuff;
using Proxy.SendProto;

public class GameStart : MonoBehaviour
{
    private Client m_client;

    void Start()
    {
        string ip = "127.0.0.1";
        int port = 3000;
        m_client = new Client(ip, port);
        m_client.Start();

        IProtocolContainer protocolContainer = new ProtocolContainer();
        ProtocolParser protocolParser = new ProtocolParser(m_client, protocolContainer);

        Channel channel = new Channel("127.0.0.1:3001", ChannelCredentials.Insecure);
        //channel.ConnectAsync(null);

        HeartBeat heartBeat = new HeartBeat(new SendHeartBeat(channel));        

        IScriptableObjectLoader scriptableObjectLoader = new ScriptableObjectLoader();
        ISceneTable sceneTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.SceneTable) as ISceneTable;
        ISceneSystem sceneSystem = new SceneSystem(sceneTable);
        IGameSetting gameSetting = new GameSetting();
        IUIPrefabTable uiPrefabTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.UISystemTable) as IUIPrefabTable;
        IUILoader uiLoader = new UILoader(uiPrefabTable);
        IUISystem uiSystem = new UISystem(uiLoader);
        IGameProcessSystem gameProcessSystem = new GameProcessSystem(gameSetting, sceneSystem, uiSystem);
        IMain gameMainLoop = new Main(gameProcessSystem);
        gameMainLoop.Start();

        DontDestroyOnLoad(this);
    }

    private void OnDestroy()
    {
        m_client.DisConnect();
    }
}

