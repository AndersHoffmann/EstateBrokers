﻿using System;
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
            IEvaluatePropertyOutput estimatesOutput = new EvaluatePropertyPresenter(this);
            IEvaluatePropertyInput estimatesInput = new EvaluateProperty(estimatesOutput);
            EvaluatePropertyController = new EvaluatePropertyController(estimatesInput);
            InitializeComponent();
        }


        private void button_Estimate_Click(object sender, EventArgs e)
        {
            EvaluatePropertyController.EstimateCode(textbox_SquareMeter.Text, trackbar_HouseCondition.Value, checkbox_DesignerHouse.Checked, checkbox_Garden.Checked, checkbox_Basement.Checked, checkBox_Garage.Checked);
        }

        public void UpdatePropertyValuationField(EvaluatePropertyViewModel evaluatePropertyViewModel)
        {
            textBox_FinalPrice.Text = evaluatePropertyViewModel.PropertyValuation;
        }
    }
}
