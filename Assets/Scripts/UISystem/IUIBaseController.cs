namespace UISystem
{
    public interface IUIBaseController
    {
        bool Open(int id);
        bool Close();
        void Refresh();
        void Destory();
    }
}
