using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class OpenHousePage : UserControl
    {
        public OpenHousePage()
        {
            InitializeComponent();
        }

        private void button_Clear_Click(object sender, EventArgs e)
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
