using Controllers;
using Presenters.IFrontEnd;
using System;
using System.Windows.Forms;
using ViewModels;

namespace GUI
{
    public partial class EditEntryPage : UserControl, IShowEditAbleEntryFrontEnd
    {
        GetEntryEditCaseData _getEntryEditCaseData;

        public EditEntryPage()
        {
            _getEntryEditCaseData = DependencyInjectionContainer.GetEntryEditCaseData(this);

            InitializeComponent();
        }

        private void button_searchCaseID_Click(object sender, EventArgs e)
        {
            _getEntryEditCaseData.GetEntryEditInfo(textBox_CaseID.Text);

        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        public void EntryToTextBoxes(ShowEditAbleEntryViewModel showEditAbleEntryViewModel)
        {
            //Case
            textBox_RealtorID.Text = showEditAbleEntryViewModel.realtorID;
            textBox_CreationDate.Text = showEditAbleEntryViewModel.creationDate;
            textBox_CloseDate.Text = showEditAbleEntryViewModel.closedDate;
            textBox_Price.Text = showEditAbleEntryViewModel.price;

            //Property
            textBox_EstimatedPrice.Text = showEditAbleEntryViewModel.estimatedPrice;


            //Property and Address
            textBox_PostalCode.Text = showEditAbleEntryViewModel.postalCode;
            textBox_AddressLine1.Text = showEditAbleEntryViewModel.addressLine1;

            //Address

            textBox_AddressLine2.Text = showEditAbleEntryViewModel.addressLine2;
            textBox_OwnershipCost.Text = showEditAbleEntryViewModel.ownershipCost;
            textBox_ExteriorArea.Text = showEditAbleEntryViewModel.exteriorArea;
            textBox_InteriorArea.Text = showEditAbleEntryViewModel.interiorArea;
            textBox_BuildYear.Text = showEditAbleEntryViewModel.buildYear;
        }
    }
}
