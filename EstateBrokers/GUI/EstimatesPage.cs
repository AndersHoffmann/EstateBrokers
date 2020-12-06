using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class EstimatesPage : UserControl
    {
        public EstimatesPage()
        {
           
            InitializeComponent();
            HideAllUserControlsOnEstimatePage();
        }

        private void button_PostalEstimates_Click(object sender, EventArgs e)
        {
            postalCodeEstimates1.Show();
            postalCodeEstimates1.BringToFront();
        }

        private void button_PropertyValuation_Click(object sender, EventArgs e)
        {
            propertyValuationPage1.Show();
            propertyValuationPage1.BringToFront();

        }

        private void HideAllUserControlsOnEstimatePage()
        {

            propertyValuationPage1.Hide();
            postalCodeEstimates1.Hide();

        }
    }
}
