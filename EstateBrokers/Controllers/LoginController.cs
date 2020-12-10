using UseCases.Login;

namespace Controllers
{
    public class LoginController
    {
        ILoginInput _loginInput;

        public LoginController(ILoginInput loginInput)
        {

            _loginInput = loginInput;

        }

        public void TryLogin(string username, string password)
        {
            LoginRequestModel request = new LoginRequestModel();
            request.username = username;
            request.password = password;

            _loginInput.Auth(request);
        }

    }
}
