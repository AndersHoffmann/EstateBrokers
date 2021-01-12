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
        //GRASP - Controller
        public void TryLogin(string username, string password)
        {
            LoginRequestModel request = new LoginRequestModel();
            request.Username = username;
            request.Password = password;

            _loginInput.Auth(request);
        }

    }
}
