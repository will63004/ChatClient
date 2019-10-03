using UseCase.Login;

namespace InterfaceAdapter.Adapter.Login
{
    public class LoginAdapter
    {
        private ILogin login;

        public LoginAdapter(ILogin login)
        {
            this.login = login;
        }

        public void StartLogin(ulong playerID)
        {
            login.StartLogin(playerID);
        }
    }
}

