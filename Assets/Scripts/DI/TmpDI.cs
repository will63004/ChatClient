using InterfaceAdapter.Adapter.Login;

public class TmpDI
{
    public static TmpDI m_instance;

    public static TmpDI Instance
    {
        get
        {
            if (m_instance == null)
                m_instance = new TmpDI();

            return m_instance;
        }
    }

    public LoginAdapter Login { get; set; }
}
