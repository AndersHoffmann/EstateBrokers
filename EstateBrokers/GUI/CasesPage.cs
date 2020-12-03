using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class CasesPage : UserControl
    {
        public CasesPage()
        {
            InitializeComponent();
        }

        private void button_ShowCases_Click(object sender, EventArgs e)
        {
            OnCasesPage_createEntryPage.BringToFront();
        }

        private void CasesPage_Load(object sender, EventArgs e)
        {
            OnCasesPage_createEntryPage.SendToBack();
        }
    }
}
