using Game.UI;
using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    [CreateAssetMenu(menuName = "ScriptableObject/Create UISystemTable")]
    public class UIPrefabTable : PathTable, IUIPrefabTable
    {
        public string GetUIPath(eUIPrefab type)
        {
            return GetPath((int)type);
        }
    }
}
