using System;
using UseCases.Statistics;

namespace Controllers
{
    public class EstimatesController
    {
        IEstimatesInput _estimatesInput;

        public EstimatesController(IEstimatesInput estimatesInput)
        {
            _estimatesInput = estimatesInput;

        }

        public void EstimateCode(string postalCode)
        {
            EstimatesRequestModel request = new EstimatesRequestModel();
            request.PostalCode = Int32.Parse(postalCode);
            _estimatesInput.CalculateAreaPriceByPostalCode(request);
        }
        public void AreaCodes()
        {
            _estimatesInput.GetAvailableAreaCodes();

        }

    }
}
