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
        EvaluatePropertyController evaluatePropertyController { get; set; }

        public PropertyValuationPage()
        {
            IEvaluatePropertyOutput estimatesOutput = new EvaluatePropertyPresenter(this);
            IEvaluatePropertyInput estimatesInput = new EvaluateProperty(estimatesOutput);
            evaluatePropertyController = new EvaluatePropertyController(estimatesInput);
            InitializeComponent();
        }

        public void UpdatePropertyValuationField(EvaluatePropertyViewModel evaluatePropertyViewModel)
        {
            textBox_FinalPrice.Text = evaluatePropertyViewModel.PropertyValuation;
        }
    }
}
