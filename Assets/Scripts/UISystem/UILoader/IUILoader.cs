using Game.UI;
using UnityEngine;

namespace UISystem
{
    public interface IUILoader
    {
        ResourceRequest LoadUIAsync(eUIPrefab prefab);
        T LoadUI<T>(eUIPrefab prefab) where T : Object;
        T LoadUI<T>(int index) where T : Object;
    }
}
