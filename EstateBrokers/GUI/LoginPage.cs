using Controllers;
using UseCases.Login;
using Presenters;
using System;
using System.Windows.Forms;
using ViewModels;
using Gateways;
using Database.Login;

namespace GUI
{
    public partial class LoginPage : UserControl, ILoginFrontEnd
    {
        LoginController _loginController { get; set; }
      

        public LoginPage()
        {

            _loginController = DependencyInjectionContainer.GetLoginController(this);

            InitializeComponent();

            toolTip_ForUserName.SetToolTip(pictureBox_UsernamePicture, "Type in your username");
            toolTip_ForPassword.SetToolTip(pictureBox_ForLockToPassword, "Type in your password");
            toolTip_NewUser.SetToolTip(label_NewUser, "Contact your manager for a login");
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

            _loginController.TryLogin(textbox_username.Text, TextBox_password.Text);

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }


    }
}
