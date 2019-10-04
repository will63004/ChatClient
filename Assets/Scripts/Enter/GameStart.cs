using UnityEngine;
using Game.Database;
using Game.Scene;
using Game.Main;
using Game.Database.UnityScriptableObject;
using Game.UI;
using Grpc.Core;
using TcpService.Service;
using Proxy.SendProto;
using UseCase.HeartBeat;
using UseCase.Login;
using Game.Player;
using InterfaceAdapter.Adapter.Login;
using Unity;
using Unity.Injection;

public class GameStart : MonoBehaviour
{
    private Client m_client;

    public static IUnityContainer container;

    void Start()
    {
        //string ip = "127.0.0.1";
        //int port = 3000;
        //m_client = new Client(ip, port);
        //m_client.Start();

        //IProtocolContainer protocolContainer = new ProtocolContainer();
        //ProtocolParser protocolParser = new ProtocolParser(m_client, protocolContainer);

        IScriptableObjectLoader scriptableObjectLoader = new ScriptableObjectLoader();
        ISceneTable sceneTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.SceneTable) as ISceneTable;
        ISceneSystem sceneSystem = new SceneSystem(sceneTable);
        IGameSetting gameSetting = new GameSetting();
        IUIPrefabTable uiPrefabTable = scriptableObjectLoader.LoadScriptableObject(eScriptableObject.UISystemTable) as IUIPrefabTable;
        IUILoader uiLoader = new UILoader(uiPrefabTable);
        IUISystem uiSystem = new UISystem(uiLoader);
        IGameProcessSystem gameProcessSystem = new GameProcessSystem(gameSetting, sceneSystem, uiSystem);
        gameProcessSystem.ChangeProcess(eGameProcess.Login);        
        
        container = new UnityContainer();         
        container.RegisterSingleton<Channel>(new InjectionConstructor(new object[] { "127.0.0.1:3001", ChannelCredentials.Insecure })).Resolve<Channel>();
        container.RegisterSingleton<ISendHeartBeat, HeartBeatHandler>().Resolve<ISendHeartBeat>();
        container.RegisterSingleton<ILoginHandler, LoginHandler>().Resolve<ILoginHandler>();
        container.RegisterSingleton<Player>().Resolve<Player>();
        container.RegisterSingleton<ILogin, Login>().Resolve<ILogin>();
        container.RegisterSingleton<LoginAdapter>().Resolve<LoginAdapter>();

        DontDestroyOnLoad(this);
    }

    private void OnDestroy()
    {
        //m_client.DisConnect();
    }
}

