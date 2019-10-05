using Game.Database;
using Game.UI;
using System.Collections.Generic;
using UnityEngine;

namespace UISystem
{
    public class UILoader:IUILoader
    {
        private IUIPrefabTable UIPrefabTable { get; set; }

        public UILoader(IUIPrefabTable uiPrefabTable)
        {
            UIPrefabTable = uiPrefabTable;
        }

        public ResourceRequest LoadUIAsync(eUIPrefab prefab)
        {
            string path = UIPrefabTable.GetUIPath(prefab);
            ResourceRequest operation = Resources.LoadAsync<GameObject>(path);            
            return operation;
        }

        public T LoadUI<T>(eUIPrefab prefab) where T: Object
        {
            string path = UIPrefabTable.GetUIPath(prefab);
            T go = Resources.Load<T>(path);
            return go;
        }

        public T LoadUI<T>(int index) where T : Object
        {
            string path = UIPrefabTable.GetUIPath(index);
            T go = Resources.Load<T>(path);            
            return go;
        }
    }
}
