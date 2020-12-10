using UseCases.Login;
using ViewModels;


namespace Presenters
{
    public partial class LoginPresenter : ILoginOutput
    {
        ILoginFrontEnd _frontEnd;

        public LoginPresenter(ILoginFrontEnd frontEnd)
        {
            _frontEnd = frontEnd;

        }

        public void ConfirmLogin(LoginResponseModel response)
        {
            LoginViewModel loginViewModel = new LoginViewModel();

            loginViewModel.LoginSucess = response.LoginSucess;

            _frontEnd.LoginAttempt(loginViewModel);

        }

    }
}
