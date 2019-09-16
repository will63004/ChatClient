using Game.Scene;

namespace Game.Database.UnityScriptableObject
{
    public interface ISceneTable
    {
        string GetScenePath(eScene type);
    }
}