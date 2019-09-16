using Game.Scene;
using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    [CreateAssetMenu(menuName = "ScriptableObject/Create SceneTable")]
    public class SceneTable : PathTable, ISceneTable
    {
        public string GetScenePath(eScene type)
        {
            return GetPath((int)type);
        }
    }
}
