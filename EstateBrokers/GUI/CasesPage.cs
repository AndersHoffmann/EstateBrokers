using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class CasesPage : UserControl
    {
        public CasesPage()
        {
            InitializeComponent();
            HideAllUserControls();
        }

        private void button_ShowCases_Click(object sender, EventArgs e)
        {
            getEntryPage1.Show();
            getEntryPage1.BringToFront();
        }

        private void button_CreateCase_Click(object sender, EventArgs e)
        {
            createEntryPage1.Show();
            createEntryPage1.BringToFront();
        }


        private void button_UpdateCase_Click(object sender, EventArgs e)
        {
            editEntryPage1.Show();
            editEntryPage1.BringToFront();
        }


        private void HideAllUserControls()
        {
            createEntryPage1.Hide();
            getEntryPage1.Hide();
            editEntryPage1.Hide();

        }
    }
}
