using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ViewModels;
using Presenters;
using UseCases.PaymentCalculator;
using Gateways;
using Controllers;
using System.Windows.Forms;
using Bank;

namespace GUI
{
    public partial class EstimatesPage : UserControl, IPaymentCalculatorFrontEnd
    {
        PaymentCalculatorController _paymentCalculateController;

        public EstimatesPage()
        {

            _paymentCalculateController = DependencyInjectionContainer.GetPaymentCalculatorController(this);

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

        private void button_LoanEstimate_Click(object sender, EventArgs e)
        {

            _paymentCalculateController.CalculatePayment(textBox_HousePrice.Text, textBox_NumberOfPayments.Text);

        }

        public void PricePerMonthToText(PaymentCalculatorViewModel paymentCalculatorView)
        {
            textBox_PricePerMonth.Text = paymentCalculatorView.PricePerMonth.ToString();
        }
    }
}
