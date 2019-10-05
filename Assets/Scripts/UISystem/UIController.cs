using UnityEngine;

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

        public void OpenUI(int index)
        {
            if (!presenter.OpenUI(index))
                Debug.LogError("OpenUI Error, Index is " + index);
        }
    }
}
