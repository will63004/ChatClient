namespace UISystem
{
    public class UIPresenter
    {
        private UIContext context;

        private IUIView view;

        public UIPresenter(UIContext context, IUIView view)
        {
            this.context = context;
            this.view = view;
        }

        public bool OpenUI(int index)
        {
            if (context.OpenUIIndexs.IsContainIndex(index))
                return false;

            context.OpenUIIndexs.Add(index);
            context.DirtyIndexs.Add(index);

            UIUnitState unit;
            if (context.UnitsState.TryGetValue(index, out unit))
            {
                unit.PreState = unit.State;
                unit.State = eState.Open;
            }
            else
                context.UnitsState.Add(index, new UIUnitState() { State = eState.Open });

            view.refresh();

            return true;
        }
    }
}
