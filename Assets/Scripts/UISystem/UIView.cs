namespace UISystem
{
    public class UIView : IUIView
    {
        private UIContext context;
        private IUIImplContainer implContainer;

        public UIView(UIContext context, IUIImplContainer implContainer)
        {
            this.context = context;
            this.implContainer = implContainer;
        }

        public void Open(int id)
        {
            IUIBaseController bc = implContainer.GetImpl(id);
            bc.Open(id);
        }

        public void Close(int id)
        {
            IUIBaseController bc = implContainer.GetImpl(id);
            bc.Close();
        }
    }
}
