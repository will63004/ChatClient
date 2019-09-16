using UnityEngine;

namespace Game.UI
{
    public interface IUISystem
    {
        AsyncOperation ChangeState(eUIState state);
    }
}