using UseCases.Login;
using ViewModels;


namespace Presenters
{
    public partial class LoginPresenter : ILoginOutput
    {
        ILoginFrontEnd FrontEnd { get; set; }

        public LoginPresenter(ILoginFrontEnd frontEnd)
        {
            FrontEnd = frontEnd;

        }

        public void ConfirmLogin(LoginResponseModel response)
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            loginViewModel.LoginSucess = response.LoginSucess;

            FrontEnd.LoginAttempt(loginViewModel);

        }

    }
}
