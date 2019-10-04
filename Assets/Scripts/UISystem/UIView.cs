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

        public void refresh()
        {
            for (int i = 0; i < context.DirtyIndexs.Count; ++i)
            {
                int index = context.DirtyIndexs[i];
                UIUnitState unit;
                if (context.UnitsState.TryGetValue(index, out unit))
                {
                    if(unit.PreState != unit.State)
                    {
                        IUIBaseController bc = implContainer.GetImpl(index);
                        switch (unit.State)
                        {
                            case eState.Open:
                                bc.Open(index);
                                break;
                            case eState.Close:
                                bc.Close();
                                break;
                        }
                    }
                }
            }
        }
    }
}
