using Controllers;
using Presenters;
using System;
using System.Windows.Forms;
using UseCases.ShowCases;
using ViewModels;

namespace GUI
{
    public partial class GetEntryPage : UserControl, IGetEntryFrontEnd
    {
        ShowEntryController showentrycontroller { get; set; }

        public GetEntryPage()
        {
            IShowEntryOutput entryOutput = new GetEntryPresenter(this);
            IShowEntryInput entryInput = new ShowEntries(entryOutput);
            showentrycontroller = new ShowEntryController(entryInput);

            InitializeComponent();

        }

        private void GetEntryPage_Load(object sender, EventArgs e)
        {


        }

        private void button_LoadEntries_Click(object sender, EventArgs e)
        {
            showentrycontroller.StartShowEntries();
        }


        public void EntriesForDataGridView(ShowEntriesViewModel showEntriesViewModel)
        {
            dataGridView_ShowEntries.DataSource = showEntriesViewModel.Entries;
        }

   
    }
}
