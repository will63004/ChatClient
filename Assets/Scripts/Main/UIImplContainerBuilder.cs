using Main.UIImplement;
using Main.UIImplement.Login;
using UISystem;
using Unity;
using Unity.Resolution;

namespace Main
{
    public class UIImplContainerBuilder
    {
        private IUnityContainer container;

        public UIImplContainerBuilder(IUnityContainer container)
        {
            this.container = container;            
        }

        public IUIImplContainer Create()
        {
            IUIImplContainer uic = container.RegisterSingleton<IUIImplContainer, UIImplContainer>().Resolve<IUIImplContainer>();
            container.RegisterSingleton<IUIBaseContext, UILoginContext>(nameof(UILoginContext));
            container.RegisterSingleton<IUIBaseController, CUILogin>(nameof(CUILogin)).Resolve<IUIBaseController>(nameof(CUILogin),
                new ParameterOverride(typeof(IUIBaseContext), container.Resolve<IUIBaseContext>(nameof(UILoginContext))));

            uic.AddImpl((int)eUIImplement.Login, container.Resolve<IUIBaseController>(nameof(CUILogin)));

            return uic;
        }
    }
}
