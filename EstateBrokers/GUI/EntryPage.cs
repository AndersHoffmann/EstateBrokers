﻿using System;
using System.Windows.Forms;
using Controllers;
using ViewModels;
using Presenters.IFrontEnd;
namespace GUI
{
    public partial class EntryPage : UserControl, IDeleteEntryFrontEnd
    {

        DeleteEntryController _deleteEntryController;

        public EntryPage()
        {
            _deleteEntryController = DependencyInjectionContainer.DeleteEntryController(this);

            InitializeComponent();
            HideAllUserControls();
        }

        private void button_ShowCases_Click(object sender, EventArgs e)
        {
            getEntryPage1.Show();
            getEntryPage1.BringToFront();
        }

        private void button_CreateCase_Click(object sender, EventArgs e)
        {
            createEntryPage1.Show();
            createEntryPage1.BringToFront();
        }


        private void button_UpdateCase_Click(object sender, EventArgs e)
        {
            editEntryPage1.Show();
            editEntryPage1.BringToFront();
        }


        private void HideAllUserControls()
        {
            createEntryPage1.Hide();
            getEntryPage1.Hide();
            editEntryPage1.Hide();

        }

        private void button_DeleteCase_Click(object sender, EventArgs e)
        {

        }

        public void confirmCaseDelete(DeleteEntryViewModel deleteEntryViewModel)
        {
            if (deleteEntryViewModel.CaseDeleteSucess == true)
            {
                MessageBox.Show($"Case id ** {textBox_CaseIdToDelete.Text} ** is now deleted");
                textBox_CaseIdToDelete.Clear();
            }
        }
    }
}
