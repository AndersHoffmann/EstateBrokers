using Gateways;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace UseCases.Statistics
{
    public class CalculateAverageM2PriceForArea : IEstimatesInput
    {

        IEstimatesOutput _estimatesOutput;
        ICaseCRUD _caseCRUD;
        IPropertyCRUD _propertyCRUD;

        public CalculateAverageM2PriceForArea(IEstimatesOutput estimatesOutput, ICaseCRUD caseCRUD, IPropertyCRUD propertyCRUD)
        {
            _estimatesOutput = estimatesOutput;
            _caseCRUD = caseCRUD;
            _propertyCRUD = propertyCRUD;
        }
        public void CalculateAreaPriceByPostalCode(EstimatesRequestModel request)
        {

            List<Entities.Case> cases = _caseCRUD.ReadCasesInPostalCode(request.PostalCode);
            double totalPrice = 0;
            int count = 0;
            foreach (var item in cases)
            {
                totalPrice = totalPrice + item.Price;
                count++;
            }
            EstimatesResponseModel response = new EstimatesResponseModel();

            response.AverageHousePrice = totalPrice / count;

            _estimatesOutput.DisplayData(response);
        }


        public void GetAvailableAreaCodes()
        {
            GetAreaCodesResponseModel responseModel = new GetAreaCodesResponseModel();
            var thread = new Thread(() =>
            {

                responseModel.AvailableAreaCodes = _propertyCRUD.GetAllProperties().Select(c => c.PostalCode).Distinct().ToList(); 

            });

            thread.Start();
            thread.Join();

            _estimatesOutput.DisplayAvailableAreaCodes(responseModel);
        }
    }
}
