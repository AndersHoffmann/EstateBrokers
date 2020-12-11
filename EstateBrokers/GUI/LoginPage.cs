using Controllers;
using Presenters;
using System;
using System.Windows.Forms;
using ViewModels;

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
                ClearLogInData();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid username or password");

            }

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            _loginController.TryLogin(textbox_username.Text, TextBox_password.Text);
        }

        private void ClearLogInData()
        {

            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();

                }
            }
        }
    }
}
