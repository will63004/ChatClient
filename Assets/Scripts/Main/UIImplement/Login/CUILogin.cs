using System;
using InterfaceAdapter.Adapter.Login;
using UISystem;

namespace Main.UIImplement.Login
{
    public class CUILogin : UIBaseController
    {
        private UILogin view;

        private UILoginContext context;

        private LoginAdapter loginAdapter;

        public CUILogin(UIContainer container, IUIBaseContext baseContext, LoginAdapter loginAdapter) : base(container, baseContext)
        {
            this.loginAdapter = loginAdapter;
        }

        protected override void Created()
        {
            view = baseView.GetComponent<UILogin>();

            context = baseContext as UILoginContext;

            view.OnClickLogin += onClickLogin;

            view.OnIpChanged += onIpChanged;

            base.Created();
        }

        protected override void Destoryed()
        {
            view.OnClickLogin -= onClickLogin;

            view.OnIpChanged -= onIpChanged;

            base.Destoryed();
        }

        public override void Refresh()
        {
            view.SetPlayerID(context.PlayerId);

            base.Refresh();
        }

        private void onClickLogin()
        {
            loginAdapter.StartLogin(context.Ip, context.PlayerId);
        }

        private void onIpChanged(string text)
        {
            context.Ip = text;
        }
    }
}
