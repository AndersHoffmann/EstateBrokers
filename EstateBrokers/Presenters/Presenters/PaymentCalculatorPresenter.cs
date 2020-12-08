using UseCases.PaymentCalculator;
using ViewModels;
namespace Presenters
{
    public partial class PaymentCalculatorPresenter : IPaymentCalculatorOutput
    {

        IPaymentCalculatorFrontEnd FrontEnd { get; set; }

        public PaymentCalculatorPresenter(IPaymentCalculatorFrontEnd frontEnd)
        {
            FrontEnd = frontEnd;
        }


        public void FinalPricePerMonth(PaymentCalculatorResponseModel response)
        {
            PaymentCalculatorViewModel paymentCalculatorViewModel = new PaymentCalculatorViewModel();

            paymentCalculatorViewModel.PricePerMonth = response.PricePerMonth;

            FrontEnd.PricePerMonthToText(paymentCalculatorViewModel);
        }
    }
}
