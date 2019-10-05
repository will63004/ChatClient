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
            init(index);            

            return true;
        }

        private void init(int index)
        {
            view = container.GetUIPrefabUnderRoot(index);
            if (!view.activeSelf)
                view.SetActive(true);
        }

        public bool Close()
        {
            view.SetActive(false);
            return true;
        }
    }
}
