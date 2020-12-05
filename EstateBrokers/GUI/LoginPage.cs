using Controllers;
using Database.Login;
using Presenters;
using System;
using System.Windows.Forms;
using ViewModels;

namespace GUI
{
    public partial class LoginPage : UserControl, ILoginFrontEnd
    {
        LoginController loginController { get; set; }

        public LoginPage()
        {
            ILoginOutput loginOutput = new LoginPresenter(this);
            ILoginInput loginInput = new Login(loginOutput);
            loginController = new LoginController(loginInput);


            InitializeComponent();
        }

        public void LoginAttempt(LoginViewModel loginViewModel)
        {

            if (loginViewModel.LoginSucess == true)
            {

                MessageBox.Show("Login sucess");
                this.Dispose();

            }
            else
            {
                MessageBox.Show("Invalid username or password");

            }

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {

            loginController.TryLogin(textbox_username.Text, TextBox_password.Text);

        }
    }
}
