using Gateways;


namespace UseCases.PaymentCalculator
{

    public class CalculateMonthlyPayment : IPaymentCalculatorInput
    {
        IPaymentCalculatorOutput _paymentCalculatorOutput;
        IBank _bank;

        public CalculateMonthlyPayment(IPaymentCalculatorOutput paymentCalculatorOutput, IBank bank)

        {
            _paymentCalculatorOutput = paymentCalculatorOutput;
            _bank = bank;
        }

        public void CalculatePayment(PaymentCalculatorRequestModel request)
        {

            var response = new PaymentCalculatorResponseModel();

            response.PricePerMonth = _bank.PaymentCalculator(request.Price, request.LoanDuration);

            _paymentCalculatorOutput.FinalPricePerMonth(response);


        }
    }
}
