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

            base.Created();
        }

        public override void Refresh()
        {
            view.SetPlayerID(context.PlayerID);

            base.Refresh();
        }

        private void onClickLogin()
        {
            loginAdapter.StartLogin(context.PlayerID);
        }
    }
}
