using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Controllers;
using Presenters;
using ViewModels;
using Database.Login;

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
