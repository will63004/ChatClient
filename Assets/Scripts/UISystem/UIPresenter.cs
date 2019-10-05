using System;
using UnityEngine;

namespace UISystem
{
    public class UIPresenter
    {
        private UIContext context;

        private IUIView view;

        public UIPresenter(UIContext context, IUIView view)
        {
            this.context = context;
            this.view = view;
        }

        public bool OpenUI(int id)
        {
            if (context.OpenUIIDs.Contains(id))
            {
                Debug.LogError("OpenUI Error, ID is " + id);
                return false;
            }   

            context.OpenUIIDs.Add(id);

            if (context.UnitsState.TryGetValue(id, out UIUnitState unit))
            {
                unit.PreState = unit.State;
                unit.State = eState.Open;
            }
            else
                context.UnitsState.Add(id, new UIUnitState() { State = eState.Open });

            view.Open(id);

            view.Refresh(id);

            return true;
        }

        public bool CloseUI(int id)
        {
            int index = context.OpenUIIDs.FindIndex(x => x == id);
            if (index != -1)
            {
                context.OpenUIIDs.RemoveAt(index);

                if (context.UnitsState.TryGetValue(id, out UIUnitState unit))
                {
                    unit.PreState = unit.State;
                    unit.State = eState.Close;
                }
            }
            else
            {
                Debug.LogError("試圖關閉未開啟的UI, ID is " + id);
                return false;
            }

            view.Close(id);

            return true;
        }
    }
}
