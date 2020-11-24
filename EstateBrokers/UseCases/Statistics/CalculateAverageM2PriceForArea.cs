using System;
using Entities;
using Gateways;
using System.Collections.Generic;

namespace UseCases.Statistics
{
    class CalculateAverageM2PriceForArea
    {
        private IEstimatesInput _estimatesInput;
        //public CalculateAverageM2PriceForArea(IEstimatesInput ie)
        //{

        //    _estimatesInput = ie;
            

        //}

        public double Calculate(int postalCode)
        {
            ICaseCRUD crud = new CaseCRUD();
            List<Case> cases = crud.ReadCases(postalCode);
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
