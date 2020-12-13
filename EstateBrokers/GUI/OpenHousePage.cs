using Controllers;
using Presenters;
using System;
using System.Windows.Forms;
using ViewModels;

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

            ClearControls();
        }

        private void button_Assign_Click(object sender, EventArgs e)
        {
            _openHouseController.OpenHouseDistribution(numericUpDown_RealtorID1.Value, numericUpDown_RealtorID2.Value, numericUpDown_RealtorID3.Value);
        }

        public void ListsForCaseAssign(OpenHouseViewModel openHouseViewModel)
        {
            listBox_casesId1.DataSource = openHouseViewModel.Realtor1Cases;
            listbox_CasesId2.DataSource = openHouseViewModel.Realtor2Cases;
            listbox_CasesId3.DataSource = openHouseViewModel.Realtor3Cases;

        }

        private void ClearControls()
        {
            foreach (Control control in Controls)
            {
                if (control is ListBox)
                {
                    (control as ListBox).DataSource = null;
                }
                if (control is NumericUpDown)
                {
                    (control as NumericUpDown).Value = 0;
                }
            }

        }
    }
}
