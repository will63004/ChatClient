using UnityEngine;
using Game.Database;
using Game.Scene;
using Main;
using Game.Database.UnityScriptableObject;
using Grpc.Core;
using TcpService.Service;
using Proxy.SendProto;
using UseCase.HeartBeat;
using UseCase.Login;
using Game.Player;
using InterfaceAdapter.Adapter.Login;
using Unity;
using Unity.Injection;
using UISystem;

namespace Main
{
    public class Program: MonoBehaviour
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

            container = new UnityContainer();
            container.RegisterSingleton<Channel>(new InjectionConstructor(new object[] { "127.0.0.1:3001", ChannelCredentials.Insecure })).Resolve<Channel>();
            container.RegisterSingleton<ISendHeartBeat, HeartBeatHandler>().Resolve<ISendHeartBeat>();
            container.RegisterSingleton<ILoginHandler, LoginHandler>().Resolve<ILoginHandler>();
            container.RegisterSingleton<Player>().Resolve<Player>();
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
            //m_client.DisConnect();
        }
    }
}
