using UnityEngine;

namespace Game.Scene
{
    public interface ISceneSystem
    {
        AsyncOperation ChangeState(eScene type);
    }
}
