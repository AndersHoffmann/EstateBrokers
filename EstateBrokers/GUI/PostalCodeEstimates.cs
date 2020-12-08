using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presenters;
using Controllers;
using UseCases.Statistics;
using ViewModels;

namespace GUI
{
    public partial class PostalCodeEstimates : UserControl, IEstimatesFrontEnd
    {

        EstimatesController _estimatesController { get; set; }

        public PostalCodeEstimates()
        {
            _estimatesController = DependencyInjectionContainer.GetEstimatesController(this);
            InitializeComponent();
        }

        private void EstimatesPage_Load(object sender, EventArgs e)
        {

        }

        private void button_check_Click(object sender, EventArgs e)
        {
             _estimatesController.EstimateCode(textBox_AreaCodeInput.Text);
        }

        public void UpdateAveragePriceField(EstimatesViewModel estimatesViewModel)
        {
            textBox_AvaragePricePerSquareMeter.Text = estimatesViewModel.AveragePriceOfHouses;
        }

        private void button_AddToList_Click(object sender, EventArgs e)
        {
            listBox_AveragePricePerSquareMeter.Items.Add($"Postal code: {textBox_AreaCodeInput.Text} ------ Price per square meter {textBox_AvaragePricePerSquareMeter.Text}");
        }
    }
}
