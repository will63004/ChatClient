using System.Collections.Generic;
using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    [CreateAssetMenu(menuName = "ScriptableObject/Create ScriptableObjectTable")]
    public class ScriptableObjectTable : ScriptableObject, IScriptableObjectTable
    {
        [SerializeField]
        private List<string> Paths = new List<string>();

        public string getScripableObjectPath(eScriptableObject type)
        {
            int index = (int)type;
            if (Paths.IsContainIndex(index))
                return Paths[index];

            Debug.LogError("Path not contain, eScriptableObject is " + type.ToString());
            return string.Empty;
        }
    }
}
