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
            loginPage1.BringToFront();
        }

        private void button_Close_FrontPage_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button_estimates_mainpage_Click(object sender, EventArgs e)
        {
            
        }

        private void estimatesPage1_Load(object sender, EventArgs e)
        {

        }

        private void button_cases_mainpage_Click(object sender, EventArgs e)
        {

            CasesPage cs = new CasesPage();
            cs.BringToFront();


        }

        private void button_support_mainpage_Click(object sender, EventArgs e)
        {

        }
    }
}
