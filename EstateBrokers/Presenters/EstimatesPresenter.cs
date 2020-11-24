using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Statistics;
using ViewModels;

namespace Presenters
{
    public class EstimatesPresenter : IEstimatesOutput
    {
        EstimatesViewModel viewModel;
        public void DisplayData(EstimatesResponseModel reponse)
        {

            viewModel.PostalCode = reponse.PostalCode.ToString();
            viewModel.City = reponse.City;

            UpdateView(this.viewModel);
        }

        public void UpdateView(EstimatesViewModel viewModel)
        {
            //Textbox1.Text = viewModel.PostalCode;
            //...
        }
    }
}
