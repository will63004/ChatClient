using UnityEngine;

namespace UISystem
{
    public class UIContainer
    {
        private IUILoader uiLoader;

        public UIContainer(IUILoader uiLoader)
        {
            this.uiLoader = uiLoader;
        }

        public GameObject GetUIPrefab(int index)
        {
            return uiLoader.LoadUI<GameObject>(index);
        }
    }
}
