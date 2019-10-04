using UnityEngine;

namespace UISystem
{
    public class UIBaseController: IUIBaseController
    {
        private UIContainer container;

        protected GameObject view;

        public UIBaseController(UIContainer container)
        {
            this.container = container;
        }

        public bool Open(int index)
        {
            view = container.GetUIPrefab(index);

            return true;
        }

        public bool Close()
        {
            return true;
        }
    }
}
