using System.Collections.Generic;
using UnityEngine;

namespace Game.UI
{
    public class UISystem : IUISystem
    {
        private IUILoader UILoader { get; set; }

        private Canvas rootCanvas;
        private Transform rootCanvasTransform;
        private List<GameObject> uiGroup;

        public UISystem(IUILoader uiLoader)
        {
            UILoader = uiLoader;
                        
            GameObject go = UILoader.LoadUI<GameObject>(eUIPrefab.UIRoot);
            go = MonoBehaviour.Instantiate(go);
            rootCanvas = go.GetComponent<Canvas>();
            rootCanvasTransform = go.GetComponent<Transform>();
            MonoBehaviour.DontDestroyOnLoad(go);

            uiGroup = new List<GameObject>();
        }

        ~UISystem()
        {
            rootCanvas = null;
            
            uiGroup.Clear();
        }

        public AsyncOperation ChangeState(eUIState state)
        {
            switch (state)
            {
                case eUIState.Login:                    
                    ResourceRequest operation = UILoader.LoadUIAsync(eUIPrefab.Login);
                    operation.completed += onUILoadDone;
                    return operation;
            }

            return null;
        }

        private void onUILoadDone(AsyncOperation obj)
        {
            ResourceRequest req = (ResourceRequest)obj;
            GameObject go = (GameObject)req.asset;
            go = MonoBehaviour.Instantiate(go);
            go.transform.SetParent(rootCanvasTransform, false);
            uiGroup.Add(go);

            obj.completed -= onUILoadDone;
        }
    }
}
