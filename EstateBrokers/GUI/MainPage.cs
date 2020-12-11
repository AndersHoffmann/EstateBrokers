using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presenters;
using Controllers;
using ViewModels;
using UseCases.Statistics;

namespace GUI
{
    public partial class MainPage : Form
    {
        
        public MainPage()
        {
       
            InitializeComponent();
            //  loginPage1.BringToFront();
            loginPage1.Hide();
            HideAllUserControls();
            
        }

        private void button_Close_FrontPage_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to exit? - Remember to save your work before you exit";
            string caption = "Confirm";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            var result = MessageBox.Show(message, caption, buttons);

            if (result == DialogResult.Yes)
            {
                this.Dispose();
                this.Close();
            }
        }

        private void button_Home_FrontPage_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            panel_MainContainer.BringToFront();
           
        }

        private void button_cases_mainpage_Click(object sender, EventArgs e)
        {
            casesPage1.Show();
            casesPage1.BringToFront();
        }

        private void button_openhouse_mainpage_Click(object sender, EventArgs e)
        {
            openHousePage1.Show();
            openHousePage1.BringToFront();

        }

        private void button_estimates_mainpage_Click(object sender, EventArgs e)
        {

            estimatesPage1.Show();
            estimatesPage1.BringToFront();

        }

        private void button_support_mainpage_Click(object sender, EventArgs e)
        {
            supportPage1.Show();
            supportPage1.BringToFront();

        }
        private void HideAllUserControls()
        {

            casesPage1.Hide();
            openHousePage1.Hide();
            estimatesPage1.Hide();
            supportPage1.Hide();

        }

        private void button_LogOut_Click(object sender, EventArgs e)
        {
            HideAllUserControls();
            loginPage1.Show();
            loginPage1.BringToFront();
        }
    }
}
