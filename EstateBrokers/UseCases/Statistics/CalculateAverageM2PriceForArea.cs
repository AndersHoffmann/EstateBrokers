using System;
using Entities;
using Gateways;
using System.Collections.Generic;
using Database;

namespace UseCases.Statistics
{
    public class CalculateAverageM2PriceForArea : IEstimatesInput
    {

        IEstimatesOutput _estimatesOutput;
        ICaseCRUD _caseCRUD;
        public CalculateAverageM2PriceForArea(IEstimatesOutput estimatesOutput, ICaseCRUD caseCRUD)
        {
            _estimatesOutput = estimatesOutput;
            _caseCRUD = caseCRUD;
        }
        public void Calculate(EstimatesRequestModel request)
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

       
    }
}
