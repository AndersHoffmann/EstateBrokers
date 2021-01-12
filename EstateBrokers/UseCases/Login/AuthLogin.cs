using System.Threading;
using Gateways;

namespace UseCases.Login
{
    public class AuthLogin : ILoginInput
    {

        public static ILoginOutput LoginOutput;
        public static LoginRequestModel RequestModel;
        public static ILogin Login;

        public AuthLogin(ILoginOutput loginOutput, ILogin login)
        {
            LoginOutput = loginOutput;
            Login = login;

        }
        //Thread Tråd
        public void Auth(LoginRequestModel request)
        {
            var response = new LoginResponseModel();

            var thread = new Thread(() =>
            {
                response.LoginSucess = Login.TryLogin(request.Username, request.Password);

            });
            thread.Start();
            thread.Join();
            LoginOutput.ConfirmLogin(response);
        }

    }
}
