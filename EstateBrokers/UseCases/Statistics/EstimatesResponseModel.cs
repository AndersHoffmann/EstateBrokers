using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.Statistics
{
    class EstimatesResponseModel
    {

        public void Estimate(int postalCode)
        {
            EstimatesRequestModel es = new EstimatesRequestModel();
            es.PostalCode = postalCode;
            CalculateAverageM2PriceForArea ca = new CalculateAverageM2PriceForArea();
            ca.Calculate(es.PostalCode);

        }


    }
}
