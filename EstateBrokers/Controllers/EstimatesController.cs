using UseCases.Statistics;

namespace Controllers
{
    class EstimatesController : IEstimatesInput
    {

        public EstimatesRequestModel CheckCode(int postalCode)
        {
            //Check
            EstimatesRequestModel es = new EstimatesRequestModel();
            es.PostalCode = postalCode;
            return es;
        }



    }
}
