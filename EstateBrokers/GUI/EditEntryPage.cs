using Controllers;
using Presenters.IFrontEnd;
using System;
using System.Windows.Forms;
using ViewModels;

namespace GUI
{
    public partial class EditEntryPage : UserControl, IShowEditAbleEntryFrontEnd
    {
        UpdateEntryController _getEntryEditCaseData;

        public EditEntryPage()
        {
            _getEntryEditCaseData = DependencyInjectionContainer.GetEntryEditCaseData(this);

            InitializeComponent();
        }

        private void button_searchCaseID_Click(object sender, EventArgs e)
        {
            _getEntryEditCaseData.GetEntryEditInfo(numericUpDown_CaseID.Value);

        }

        private void button_save_Click(object sender, EventArgs e)
        {
            _getEntryEditCaseData.UpdateEntry(numericUpDown_CaseID.Value, numericUpDown_RealtorID.Value = numericUpDown_RealtorID.Value,
                textBox_CreationDate.Text, textBox_CloseDate.Text, numericUpDown_Price.Value, numericUpDown_EstimatedPrice.Value,
                numericUpDown_PostalCode.Value, textBox_AddressLine1.Text, textBox_AddressLine2.Text,
               numericUpDown_OwnerShipCost.Value, numericUpDown_ExteriorArea.Value, numericUpDown_InteriorArea.Value, numericUpDown_BuildYear.Value);
            ClearAllControls();

        }

        public void EntryToTextBoxes(UpdateEntryViewModel showEditAbleEntryViewModel)
        {
            //Case
            numericUpDown_RealtorID.Value = showEditAbleEntryViewModel.realtorID;
            textBox_CreationDate.Text = showEditAbleEntryViewModel.creationDate;
            textBox_CloseDate.Text = showEditAbleEntryViewModel.closedDate;
            numericUpDown_Price.Value = showEditAbleEntryViewModel.price;

            //Property
            numericUpDown_EstimatedPrice.Value = showEditAbleEntryViewModel.estimatedPrice;


            //Property and Address
            numericUpDown_PostalCode.Value = showEditAbleEntryViewModel.postalCode;
            textBox_AddressLine1.Text = showEditAbleEntryViewModel.addressLine1;

            //Address

            textBox_AddressLine2.Text = showEditAbleEntryViewModel.addressLine2;
            numericUpDown_OwnerShipCost.Value = showEditAbleEntryViewModel.ownershipCost;
            numericUpDown_ExteriorArea.Value = showEditAbleEntryViewModel.exteriorArea;
            numericUpDown_InteriorArea.Value = showEditAbleEntryViewModel.interiorArea;
            numericUpDown_BuildYear.Value = showEditAbleEntryViewModel.buildYear;
        }

        public void ShowUpdateStatus(UpdateEntryViewModel updateEntryViewModel)
        {
            if (updateEntryViewModel.UpdateSuccess == true)
            {
                MessageBox.Show("Case updated");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            ClearAllControls();
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
