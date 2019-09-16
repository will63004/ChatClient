using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    public class ScriptableObjectLoader : IScriptableObjectLoader
    {
        private const string ScriptObjectPath = "ScriptableObject\\ScriptableObjectTable";

        private IScriptableObjectTable ScriptableObjectTable { get; set; }

        public ScriptableObjectLoader()
        {
            ScriptableObjectTable = Resources.Load(ScriptObjectPath) as IScriptableObjectTable;
        }

        public ScriptableObject LoadScriptableObject(eScriptableObject type)
        {
            string path = ScriptableObjectTable.getScripableObjectPath(type);

            ScriptableObject so = Resources.Load(path) as ScriptableObject;

            if (so == null)
                Debug.LogError("Error ScriptableObjectPath, eScriptableObject is " + type.ToString() + ", Path is " + path);

            return so;
        }
    }
}
