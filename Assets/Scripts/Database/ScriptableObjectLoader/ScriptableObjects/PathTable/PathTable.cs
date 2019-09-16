using System.Collections.Generic;
using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    [CreateAssetMenu(menuName = "ScriptableObject/Create PathTable")]
    public class PathTable:ScriptableObject, IPathTable
    {
        [SerializeField]
        private List<string> Pahts = new List<string>();

        public string GetPath(int index)
        {            
            if (Pahts.IsContainIndex(index))
            {
                return Pahts[index];
            }

            Debug.LogError("Not Contain Path, index is " + index);
            return string.Empty;
        }
    }
}
