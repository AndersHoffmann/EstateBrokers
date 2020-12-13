using Controllers;
using Presenters;
using System;
using System.Windows.Forms;
using ViewModels;
namespace GUI
{
    public partial class CreateEntryPage : UserControl, ICreateEntryFrontEnd
    {

        CreateEntryController _createEntryController;

        public CreateEntryPage()
        {
            _createEntryController = DependencyInjectionContainer.GetCreateEntryController(this);
            InitializeComponent();
        }

        public void DisplayCreateCasesStatus(CasesViewModel casesViewModel)
        {
            if (casesViewModel.CreateEntrySuccess == true)
            {
                MessageBox.Show("Success");
                ClearAllControls();
            }
            else
            {
                MessageBox.Show("Creating failed");
            }


        }


        private void button_Save_Click(object sender, EventArgs e)
        {

            if (checkBox_AreYouSure.Checked)
            {
                _createEntryController.CreateEntry(numericUpDown_RealtorID.Value, numericUpDown_ListedPrice.Value, numericUpDown_EstimatedPrice.Value,
                   numericUpDown_PostalCode.Value, textbox_AddressLine1.Text, textBox_AddressLine2.Text, numericUpDown_OwnerShipCost.Value,
                    numericUpDown_ExteriorArea.Value, numericUpDown_InteriorArea.Value, numericUpDown_BuildYear.Value);
            }

            else
            {
                MessageBox.Show("Please check your data and accept its correct ");
            }

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to cancel?";
            string caption = "Cancel?";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {

            }

        }

        private void ClearAllControls()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox)
                {
                    (control as TextBox).Clear();

                }
                else if (control is NumericUpDown)
                {
                    (control as NumericUpDown).Value = 0;
                }
            }
        }
    }
}
