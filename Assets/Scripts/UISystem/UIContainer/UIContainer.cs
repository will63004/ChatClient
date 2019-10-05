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

        private GameObject GetUIPrefab(int id)
        {
            GameObject go;
            if (container.TryGetValue(id, out go))
                return go;

            go = uiLoader.LoadUI<GameObject>(id);
            return MonoBehaviour.Instantiate(go);
        }

        public GameObject GetUIPrefabUnderRoot(int id)
        {
            GameObject go = GetUIPrefab(id);
            go.transform.SetParent(GetRoot().transform, false);
            return go;
        }
    }
}
