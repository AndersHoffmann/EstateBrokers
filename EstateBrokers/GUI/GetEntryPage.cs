﻿using Controllers;
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
        ShowEntryController _showentrycontroller;
        PrintEntryController _printEntryController;

        public GetEntryPage()
        {
            //Get entry
            _showentrycontroller = DependencyInjectionContainer.GetShowEntryController(this);

            //Print entry
            _printEntryController = DependencyInjectionContainer.GetPrintEntryController(this);

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

        private void dataGridView_ShowEntries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

   
    }
}
