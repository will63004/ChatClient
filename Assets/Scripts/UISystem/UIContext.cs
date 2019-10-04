using System.Collections.Generic;

namespace UISystem
{
    public class UIContext
    {
        public List<int> OpenUIIndexs = new List<int>();

        public List<int> DirtyIndexs = new List<int>();

        public Dictionary<int, UIUnitState> UnitsState = new Dictionary<int, UIUnitState>();
    }
}
