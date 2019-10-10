using UnityEngine;

namespace UISystem
{
    public class UIBaseController: IUIBaseController
    {
        private UIContainer container;

        protected IUIBaseContext baseContext;

        protected GameObject baseView;

        public UIBaseController(UIContainer container, IUIBaseContext baseContext)
        {
            this.container = container;
            this.baseContext = baseContext;
        }

        public bool Open(int id)
        {
            if(baseView == null)
                Init(id);

            if (!baseView.activeSelf)
                baseView.SetActive(true);

            return true;
        }

        private void Init(int id)
        {
            baseView = container.GetUIPrefabUnderRoot(id);

            Created();
        }

        protected virtual void Created() { }

        public bool Close()
        {
            baseView.SetActive(false);
            return true;
        }

        public virtual void Refresh() { }

        public void Destory()
        {
            container = null;
            baseContext = null;
            baseView = null;

            Destoryed();
        }

        protected virtual void Destoryed() { }
    }
}
