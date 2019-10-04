namespace UISystem
{
    public interface IUIImplContainer
    {
        IUIBaseController GetImpl(int index);
        bool AddImpl(int index, IUIBaseController impl);
    }
}
