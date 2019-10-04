using UnityEngine;

namespace UISystem
{
    public interface IUISystem
    {
        AsyncOperation ChangeState(eUIState state);
    }
}