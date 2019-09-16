using System;
using UnityEngine;

namespace Game.UI
{
    public interface IUILoader
    {
        ResourceRequest LoadUIAsync(eUIPrefab prefab);
        T LoadUI<T>(eUIPrefab prefab) where T : UnityEngine.Object;
    }
}
