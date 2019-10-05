namespace UISystem
{
    public interface IUIImplContainer
    {
        IUIBaseController GetImpl(int id);
        bool AddImpl(int id, IUIBaseController impl);
    }
}
