using System.Collections.Generic;

namespace UISystem
{
    public class UIContext
    {
        public List<int> OpenUIIDs = new List<int>();

        public Dictionary<int, UIUnitState> UnitsState = new Dictionary<int, UIUnitState>();
    }
}
