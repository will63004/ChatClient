using UIImplement;
using UISystem;
using UISystem.UIImplContainer;
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
            IUIImplContainer uic = new UIImplContainer();
            UIContainer uiContainer = container.Resolve<UIContainer>();
            uic.AddImpl(1, new CUILogin(uiContainer));

            return uic;
        }
    }
}
