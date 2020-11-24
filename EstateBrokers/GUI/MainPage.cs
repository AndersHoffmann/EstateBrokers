﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Presenters;
using Controllers;
using ViewModels;
using UseCases.Statistics;

namespace GUI
{
    public partial class MainPage : Form, IFrontEnd
    {
        EstimatesController estimatesController { get; set; }
        public MainPage()
        {
            IEstimatesOutput estimatesOutput = new EstimatesPresenter(this);
            IEstimatesInput estimatesInput = new CalculateAverageM2PriceForArea(estimatesOutput);
            estimatesController = new EstimatesController(estimatesInput);
            InitializeComponent();
        }

        public void UpdateAveragePriceField(EstimatesViewModel estimatesViewModel)
        {
            outputTextBox.Text = estimatesViewModel.AveragePriceOfHouses;
        }

        private void button_Close_FrontPage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_estimates_mainpage_Click(object sender, EventArgs e)
        {
            estimatesController.EstimateCode(InputTextBox.Text);
        }
    }
}
