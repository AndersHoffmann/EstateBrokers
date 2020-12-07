using UseCases.Login;

namespace Controllers
{
    public class LoginController
    {
        public static ILoginInput LoginInput;

        public LoginController(ILoginInput loginInput)
        {

            LoginInput = loginInput;

        }

        public void TryLogin(string username, string password)
        {
            LoginRequestModel request = new LoginRequestModel();
            request.username = username;
            request.password = password;

            LoginInput.Auth(request);
        }

    }
}
