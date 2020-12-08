using Controllers;
using Database;
using Presenters;
using System;
using System.Windows.Forms;
using UseCases;
using UseCases.CreateEntry;
using ViewModels;
namespace GUI
{
    public partial class CreateEntryPage : UserControl, ICreateEntryFrontEnd
    {

        CreateEntryController createcasecontroller { get; set; }

        public CreateEntryPage()
        {
            ICreateEntryOutput createcaseOutput = new CreateEntryPresenter(this);
            ICreateEntryInput createcaseInput = new RunCreateEntry(createcaseOutput, new CaseCRUD(), new PropertyCRUD(), new AddressCRUD());
            createcasecontroller = new CreateEntryController(createcaseInput);
            InitializeComponent();
        }

        public void DisplayCreateCasesStatus(CasesViewModel casesViewModel)
        {
            if (casesViewModel.CreateCasesSucess == true)
            {
                MessageBox.Show("Sucess");

            }
            else
            {
                MessageBox.Show("Creating failed");
            }


        }

        private void CreateCasePage_Load(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            createcasecontroller.CreateEntry(textBox_RealtorID.Text, textBox_Price.Text, textBox_EstimatedPrice.Text, textbox_PostalCode.Text, textbox_AddressLine1.Text, textBox_AddressLine2.Text, textBox_OwnershipCost.Text, textBox_ExteriorArea.Text, textBox_InteriorArea.Text, textBox_BuildYear.Text);

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
    }
}
