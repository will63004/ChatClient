using Game.Database;
using System.Threading.Tasks;
using UnityEngine;

namespace Game.UI
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
    }
}
