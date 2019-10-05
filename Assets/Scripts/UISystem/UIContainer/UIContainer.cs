using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{
    public class UIContainer
    {
        private IUILoader uiLoader;
                
        private Dictionary<int, GameObject> container = new Dictionary<int, GameObject>();

        public UIContainer(IUILoader uiLoader)
        {
            this.uiLoader = uiLoader;
        }

        private GameObject GetRoot()
        {
            return GetUIPrefab(0);
        }

        private GameObject GetUIPrefab(int index)
        {
            GameObject go;
            if (container.TryGetValue(index, out go))
                return go;

            go = uiLoader.LoadUI<GameObject>(index);
            return MonoBehaviour.Instantiate(go);
        }

        public GameObject GetUIPrefabUnderRoot(int index)
        {
            GameObject go = GetUIPrefab(index);
            go.transform.SetParent(GetRoot().transform, false);
            return go;
        }
    }
}
