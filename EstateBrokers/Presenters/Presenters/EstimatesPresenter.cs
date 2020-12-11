using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.Statistics;
using ViewModels;

namespace Presenters
{
    public partial class EstimatesPresenter : IEstimatesOutput
    {
        IEstimatesFrontEnd _frontEnd;

        public EstimatesPresenter(IEstimatesFrontEnd frontEnd)
        {
            _frontEnd = frontEnd;
        }
        
        public void DisplayData(EstimatesResponseModel response)
        {
            EstimatesViewModel estimatesViewModel = new EstimatesViewModel();

            estimatesViewModel.AveragePriceOfHouses = response.AverageHousePrice.ToString();
           
            _frontEnd.UpdateAveragePriceField(estimatesViewModel);
        }

        public void DisplayAvailableAreaCodes(GetAreaCodesResponseModel response)
        {
            AvailableAreaCodesViewModel availableAreaCodesViewModel = new AvailableAreaCodesViewModel();

            availableAreaCodesViewModel.AreaCodes = response.AvailableAreaCodes.Select(c => c.ToString()).ToList();
            _frontEnd.AreaCodesToComboBox(availableAreaCodesViewModel);
        }
    }
}
