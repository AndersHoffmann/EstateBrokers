using Controllers;
using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UseCases.OpenHouse;
using ViewModels;

namespace GUI
{
    public partial class PropertyValuationPage : UserControl, IEvaluatePropertyFrontEnd
    {
        EvaluatePropertyController EvaluatePropertyController { get; set; }

        public PropertyValuationPage()
        {
            IEvaluatePropertyOutput estimatesOutput = new EvaluatePropertyPresenter(this);
            IEvaluatePropertyInput estimatesInput = new EvaluateProperty(estimatesOutput);
            EvaluatePropertyController = new EvaluatePropertyController(estimatesInput);
            InitializeComponent();
        }

        public void UpdatePropertyValuationField(EvaluatePropertyViewModel evaluatePropertyViewModel)
        {
            textBox_FinalPrice.Text = evaluatePropertyViewModel.PropertyValuation;
        }

        private void button_Estimate_Click(object sender, EventArgs e)
        {
            EvaluatePropertyController.EstimateCode(textbox_SquareMeter.Text, trackbar_HouseCondition.Value, checkbox_DesignerHouse.Checked, checkbox_Garden.Checked, checkbox_Basement.Checked, checkBox3.Checked);
        }
    }
}
