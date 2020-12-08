using System;
using System.Collections.Generic;
using System.Text;
using UseCases.Statistics;
using ViewModels;

namespace Presenters
{
    public partial class EstimatesPresenter : IEstimatesOutput
    {
        public IEstimatesFrontEnd FrontEnd { get; set; }
        public EstimatesPresenter(IEstimatesFrontEnd frontEnd)
        {
            FrontEnd = frontEnd;
        }
        
        public void DisplayData(EstimatesResponseModel response)
        {
            EstimatesViewModel estimatesViewModel = new EstimatesViewModel();

            estimatesViewModel.AveragePriceOfHouses = response.AverageHousePrice.ToString();
           
            FrontEnd.UpdateAveragePriceField(estimatesViewModel);
        }
        
    }
}
