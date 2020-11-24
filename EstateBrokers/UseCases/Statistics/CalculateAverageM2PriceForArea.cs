using System;
using Entities;
using Gateways;
using System.Collections.Generic;

namespace UseCases.Statistics
{
    public class CalculateAverageM2PriceForArea : IEstimatesInput
    {
        public IEstimatesOutput EstimatesOutput { get; set; }
        public CalculateAverageM2PriceForArea(IEstimatesOutput estimatesOutput)
        {
            EstimatesOutput = estimatesOutput;
        }
        public double Calculate(EstimatesRequestModel request)
        {
            ICaseCRUD crud = new CaseCRUD();
            List<Case> cases = crud.ReadCases(request.PostalCode);
            double totalPrice = 0;
            int count = 0;
            foreach (var item in cases)
            {
                totalPrice = totalPrice + item.Price;
                count++;
            }
            return totalPrice / count;
        }
    }
}
