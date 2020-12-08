using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

using UseCases.OpenHouse;
using Controllers;
using ViewModels;
using Presenters;

namespace GUI
{
    public partial class OpenHousePage : UserControl, IOpenHouseFrontEnd
    {
        OpenHouseController _openHouseController;

        public OpenHousePage()
        {

            _openHouseController = DependencyInjectionContainer.GetOpenHouseController(this);

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

        private void button_Assign_Click(object sender, EventArgs e)
        {
            _openHouseController.OpenHouseDistribution(textBox_RealtorID1.Text, textBox_RealtorID2.Text, textBox_RealtorID3.Text);
        }

        public void ListsForCaseAssign(OpenHouseViewModel openHouseViewModel)
        {
            listBox_casesId1.DataSource = openHouseViewModel.Realtor1Cases;
            listbox_CasesId2.DataSource = openHouseViewModel.Realtor2Cases;
            listbox_CasesId3.DataSource = openHouseViewModel.Realtor3Cases;
            
        }
    }
}
