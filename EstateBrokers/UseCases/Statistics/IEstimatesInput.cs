

namespace UseCases.Statistics

{
    public interface IEstimatesInput
    {
        public void CalculateAreaPriceByPostalCode(EstimatesRequestModel request);

        public void GetAvailableAreaCodes();

    }
}
