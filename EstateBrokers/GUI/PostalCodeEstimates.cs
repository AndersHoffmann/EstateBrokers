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

        private void button_check_Click(object sender, EventArgs e)
        {
             _estimatesController.EstimateCode(comboBox_AreaCodes.Text);
        }

        public void UpdateAveragePriceField(EstimatesViewModel estimatesViewModel)
        {
            textBox_AvaragePricePerSquareMeter.Text = estimatesViewModel.AveragePriceOfHouses;
        }

        private void button_AddToList_Click(object sender, EventArgs e)
        {
            listBox_AveragePricePerSquareMeter.Items.Add($"Postal code: {comboBox_AreaCodes.Text} ------ Price per square meter {textBox_AvaragePricePerSquareMeter.Text}");
        }

        public void AreaCodesToComboBox(AvailableAreaCodesViewModel availableAreaCodesViewModel)
        {
            foreach (var areaCode in availableAreaCodesViewModel.AreaCodes)
            {
                comboBox_AreaCodes.Items.Add(areaCode);
            }
            
        }

        private void button_LoadAvailableAreaCodes_Click(object sender, EventArgs e)
        {
            _estimatesController.AreaCodes();
        }

        private void button_RemoveFromList_Click(object sender, EventArgs e)
        {
            listBox_AveragePricePerSquareMeter.Items.Remove(listBox_AveragePricePerSquareMeter.SelectedItem);
        }
    }
}
