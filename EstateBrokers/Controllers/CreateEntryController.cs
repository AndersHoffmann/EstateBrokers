using System;
using System.Collections.Generic;
using System.Text;

namespace Controllers
{
    class CreateEntryController
    {
        public static IEstimatesInput EstimatesInput;

        public EstimatesController(IEstimatesInput estimatesInput)
        {
            EstimatesInput = estimatesInput;

        }

        public void EstimateCode(string postalCode)
        {
            EstimatesRequestModel request = new EstimatesRequestModel();
            request.PostalCode = Int32.Parse(postalCode);
            EstimatesInput.Calculate(request);
        }

    }
}
