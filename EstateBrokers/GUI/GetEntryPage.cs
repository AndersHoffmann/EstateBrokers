using Controllers;
using Presenters;
using Presenters.IFrontEnd;
using System;
using System.Windows.Forms;
using UseCases.PrintEntries;
using UseCases.ShowCases;
using ViewModels;

namespace GUI
{
    public partial class GetEntryPage : UserControl, IGetEntryFrontEnd, IPrintEntryFrontEnd, IDeleteEntryFrontEnd
    {
        ShowEntryController _showentrycontroller;
        PrintEntryController _printEntryController;
        DeleteEntryController _deleteEntryController;

        public GetEntryPage()
        {
            //Get entry
            _showentrycontroller = DependencyInjectionContainer.GetShowEntryController(this);

            //Print entry
            _printEntryController = DependencyInjectionContainer.GetPrintEntryController(this);

            //Delete entry
            _deleteEntryController = DependencyInjectionContainer.DeleteEntryController(this);

            InitializeComponent();
        }

        private void GetEntryPage_Load(object sender, EventArgs e)
        {

            _showentrycontroller.StartShowEntries();
        }

        public void EntriesForDataGridView(ShowEntriesViewModel showEntriesViewModel)
        {
            dataGridView_ShowEntries.DataSource = showEntriesViewModel.Entries;
        }


        private void button_Reload_Click(object sender, EventArgs e)
        {
            _showentrycontroller.StartShowEntries();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            _printEntryController.PrintCases(Convert.ToInt32(textBox_CaseIDtoPrint.Text));

        }

        public void PrintSucess(PrintEntryViewModel printViewmodel)
        {

            if (printViewmodel.PrintEntrySucess == true)
            {
                MessageBox.Show("Sucess");

            }
            else
            {
                MessageBox.Show("Print failed");
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            _deleteEntryController.DeleteEntryID(textBox_CaseToDelete.Text);


        }

        public void confirmCaseDelete(DeleteEntryViewModel deleteEntryViewModel)
        {
            
                MessageBox.Show($"Case id ** {textBox_CaseToDelete.Text} ** deleted");
 
            
        }
    }
}
