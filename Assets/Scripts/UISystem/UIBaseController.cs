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
        }

        public bool Close()
        {
            return true;
        }
    }
}
