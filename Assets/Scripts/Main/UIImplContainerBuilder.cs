using UIImplement;
using UIImplement.Login;
using UISystem;
using Unity;

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
            container.RegisterSingleton<IUIBaseContext, UILoginContext>().Resolve<IUIBaseContext>();
            container.RegisterSingleton<IUIBaseController, CUILogin>(nameof(CUILogin)).Resolve<IUIBaseController>(nameof(CUILogin));


            uic.AddImpl((int)eUIImplement.Login, container.Resolve<IUIBaseController>(nameof(CUILogin)));

            return uic;
        }
    }
}
