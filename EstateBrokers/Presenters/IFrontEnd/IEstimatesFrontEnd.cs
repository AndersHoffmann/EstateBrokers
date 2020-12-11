using ViewModels;
namespace Presenters
{
    public interface IEstimatesFrontEnd
    {
        public void UpdateAveragePriceField(EstimatesViewModel estimatesViewModel);

        public void AreaCodesToComboBox(AvailableAreaCodesViewModel availableAreaCodesViewModel);
    }
}
