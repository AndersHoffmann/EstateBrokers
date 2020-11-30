using System;
using UseCases.Statistics;

namespace Controllers
{
    public class EstimatesController
    {
        public static IEstimatesInput EstimatesInput;

        public EstimatesController (IEstimatesInput estimatesInput)
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
