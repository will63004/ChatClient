using UnityEngine;

namespace Game.Database.UnityScriptableObject
{
    public interface IScriptableObjectLoader
    {
        ScriptableObject LoadScriptableObject(eScriptableObject type);
    }
}