using System.Collections.Generic;

namespace UISystem.UIImplContainer
{
    public class UIImplContainer : IUIImplContainer
    {
        private Dictionary<int, IUIBaseController> container = new Dictionary<int, IUIBaseController>();

        public IUIBaseController GetImpl(int index)
        {
            IUIBaseController impl;
            if (container.TryGetValue(index, out impl))
                return impl;

            return null;
        }

        public bool AddImpl(int index, IUIBaseController impl)
        {
            if (container.ContainsKey(index))
                return false;

            container.Add(index, impl);
            return true;
        }
    }
}
