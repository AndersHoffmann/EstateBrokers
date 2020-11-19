using System;
using System.Collections.Generic;
using System.Text;
using Gateways;
namespace UseCases
{
    class AveragePriceCalculator
    {
        public double CalculateAreaAverage(int postalCode)
        {
            List<Case> cases = new List<Case>();

            using (var database = new EstateBrokerContext())
            {
                var Cases = database.
                    
                    .ToList();
            }
        }
    }
}
