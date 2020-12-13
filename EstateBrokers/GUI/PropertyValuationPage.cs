using Controllers;
using Presenters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presenters;
using ViewModels;
using Controllers;
using UseCases.EvaluateProperty;
namespace GUI
{
    public partial class PropertyValuationPage : UserControl, IEvaluatePropertyFrontEnd
    {
        EvaluatePropertyController EvaluatePropertyController { get; set; }

        public PropertyValuationPage()
        {
            EvaluatePropertyController = DependencyInjectionContainer.GetEvaluatePropertyController(this);
            InitializeComponent();
        }


        private void button_Estimate_Click(object sender, EventArgs e)
        {
            EvaluatePropertyController.EstimateCode(numericUpDown_HouseSquareMeter.Value, trackbar_HouseCondition.Value, checkbox_DesignerHouse.Checked, checkbox_Garden.Checked, checkbox_Basement.Checked, checkBox_Garage.Checked);
        }

        public void UpdatePropertyValuationField(EvaluatePropertyViewModel evaluatePropertyViewModel)
        {
            textBox_FinalPrice.Text = evaluatePropertyViewModel.PropertyValuation;
        }
    }
}
