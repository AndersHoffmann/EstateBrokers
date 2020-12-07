using Controllers;
using Presenters;
using System;
using System.Windows.Forms;
using UseCases.PrintEntries;
using UseCases.ShowCases;
using ViewModels;

namespace GUI
{
    public partial class GetEntryPage : UserControl, IGetEntryFrontEnd, IPrintEntryFrontEnd
    {
        ShowEntryController showentrycontroller { get; set; }
        PrintEntryController printEntryController { get; set; }

        public GetEntryPage()
        {
            //Get entry
            IShowEntryOutput entryOutput = new GetEntryPresenter(this);
            IShowEntryInput entryInput = new ShowEntries(entryOutput);
            showentrycontroller = new ShowEntryController(entryInput);

            //Print entry
            IPrintEntriesOutput printOutput = new PrintEntryPresenter(this);
            IPrintEntriesInput printInput = new PrintEntry(printOutput);
            printEntryController = new PrintEntryController(printInput);

            InitializeComponent();
        }

        private void GetEntryPage_Load(object sender, EventArgs e)
        {

            showentrycontroller.StartShowEntries();
        }



        public void EntriesForDataGridView(ShowEntriesViewModel showEntriesViewModel)
        {
            dataGridView_ShowEntries.DataSource = showEntriesViewModel.Entries;
        }

        private void dataGridView_ShowEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_Reload_Click(object sender, EventArgs e)
        {
            showentrycontroller.StartShowEntries();
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            printEntryController.PrintCases(Convert.ToInt32(textBox_CaseIDtoPrint.Text));

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

   
    }
}
