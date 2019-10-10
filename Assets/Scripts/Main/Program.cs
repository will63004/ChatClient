using UnityEngine;
using Game.Database;
using Game.Scene;
using Game.Database.UnityScriptableObject;
using Grpc.Core;
using TcpService.Service;
using UseCase.HeartBeat;
using UseCase.Login;
using Game.Player;
using InterfaceAdapter.Adapter.Login;
using Unity;
using Unity.Injection;
using UISystem;
using ProtoService.ProtoBuff;
using InterfaceAdapter.Proxy.Handler;
using Proxy;
using UseCase.Player;

namespace Main
{
    public class Program: MonoBehaviour
    {
        private TcpClient m_client;

        public static IUnityContainer container;

        void Start()
        {
            container = new UnityContainer();
            m_client = container.RegisterSingleton<ITcpClient, TcpClient>(new InjectionConstructor(new object[] { "127.0.0.1", 3000})).Resolve<ITcpClient>() as TcpClient;
            m_client.Start();

            container.RegisterSingleton<IProtocolContainer, ProtocolContainer>().Resolve<IProtocolContainer>();
            container.RegisterSingleton<ISendProtocol, ProtocolParser>().Resolve<ISendProtocol>();

            container.RegisterSingleton<Channel>(new InjectionConstructor(new object[] { "127.0.0.1:3001", ChannelCredentials.Insecure })).Resolve<Channel>();
            container.RegisterSingleton<PlayerData>().Resolve<PlayerData>();
            container.RegisterSingleton<IPlayer, Player>().Resolve<IPlayer>();
            container.RegisterSingleton<ISendHeartBeat, HeartBeatHandler>().Resolve<ISendHeartBeat>();
            container.RegisterSingleton<ILoginHandler, LoginHandler>().Resolve<ILoginHandler>();            
            container.RegisterSingleton<ILogin, Login>().Resolve<ILogin>();
            container.RegisterSingleton<LoginAdapter>().Resolve<LoginAdapter>();

            IScriptableObjectLoader scriptableObjectLoader = new ScriptableObjectLoader();
            container.RegisterInstance<ISceneTable>(scriptableObjectLoader.LoadScriptableObject(eScriptableObject.SceneTable) as ISceneTable);
            container.RegisterInstance<IUIPrefabTable>(scriptableObjectLoader.LoadScriptableObject(eScriptableObject.UISystemTable) as IUIPrefabTable);

            container.RegisterSingleton<ISceneSystem, SceneSystem>().Resolve<ISceneSystem>();
            container.RegisterSingleton<IGameSetting, GameSetting>().Resolve<IGameSetting>();

            container.RegisterSingleton<IUILoader, UILoader>().Resolve<IUILoader>();
            container.RegisterSingleton<UIContainer>().Resolve<UIContainer>();
            container.RegisterInstance<IUIImplContainer>(new UIImplContainerBuilder(container).Create());
            container.RegisterSingleton<UIContext>().Resolve<UIContext>();            
            container.RegisterSingleton<IUIView, UIView>().Resolve<IUIView>();
            container.RegisterSingleton<UIPresenter>().Resolve<UIPresenter>();
            container.RegisterSingleton<IUIController, UIController>().Resolve<IUIController>();

            container.RegisterSingleton<IGameProcessSystem, GameProcessSystem>().Resolve<IGameProcessSystem>();
            GameHost gameHost = container.RegisterSingleton<GameHost>().Resolve<GameHost>();
            gameHost.Start();

            DontDestroyOnLoad(this);
        }

        private void OnDestroy()
        {
            m_client.DisConnect();
        }
    }
}
