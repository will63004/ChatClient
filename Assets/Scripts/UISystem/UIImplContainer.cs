using System.Collections.Generic;

namespace UISystem
{
    public class UIImplContainer : IUIImplContainer
    {
        private Dictionary<int, IUIBaseController> container = new Dictionary<int, IUIBaseController>();

        public IUIBaseController GetImpl(int id)
        {
            IUIBaseController impl;
            if (container.TryGetValue(id, out impl))
                return impl;

            return null;
        }

        public bool AddImpl(int id, IUIBaseController impl)
        {
            if (container.ContainsKey(id))
                return false;

            container.Add(id, impl);
            return true;
        }
    }
}
