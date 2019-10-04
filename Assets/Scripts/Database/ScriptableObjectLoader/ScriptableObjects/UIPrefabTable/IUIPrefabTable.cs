using Game.UI;

namespace Game.Database
{
    public interface IUIPrefabTable
    {
        string GetUIPath(eUIPrefab type);
        string GetUIPath(int index);
    }
}