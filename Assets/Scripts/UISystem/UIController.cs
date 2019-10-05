namespace UISystem
{
    public class UIController: IUIController
    {
        private UIContext context;

        private UIPresenter presenter;

        public UIController(UIContext context, UIPresenter presenter)
        {
            this.context = context;
            this.presenter = presenter;
        }

        public bool OpenUI(int id)
        {
            return presenter.OpenUI(id);
        }

        public bool CloseUI(int id)
        {
            return presenter.CloseUI(id);
        }
    }
}
