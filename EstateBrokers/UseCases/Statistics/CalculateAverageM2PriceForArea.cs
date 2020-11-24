using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using Gateways;

namespace UseCases.Statistics
{
    class CalculateAverageM2PriceForArea
    {
        public double Calculate(int Postalcode)
        {
            ICaseCRUD crud = new CaseCRUD();
            List<Case> cases = crud.ReadCases(Postalcode);
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
