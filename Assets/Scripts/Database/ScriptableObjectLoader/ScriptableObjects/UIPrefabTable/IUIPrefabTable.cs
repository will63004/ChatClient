using Game.UI;

namespace Game.Database
{
    public interface IUIPrefabTable
    {
        string GetUIPath(eUIPrefab type);
    }
}