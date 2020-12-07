using Gateways;


namespace UseCases.PaymentCalculator
{

    public class CalculateMonthlyPayment : IPaymentCalculatorInput
    {
        public static IPaymentCalculatorOutput PaymentCalculatorOutput;
        public static PaymentCalculatorRequestModel RequestModel;
        public static IBank Bank;

        public CalculateMonthlyPayment(IPaymentCalculatorOutput paymentCalculatorOutput, IBank bank)

        {
            PaymentCalculatorOutput = paymentCalculatorOutput;
            Bank = bank;
        }

        public void CalculatePayment(PaymentCalculatorRequestModel request)
        {

            var response = new PaymentCalculatorResponseModel();

            response.PricePerMonth = Bank.PaymentCalculator(request.Price, request.LoanDuration);

            PaymentCalculatorOutput.FinalPricePerMonth(response);


        }
    }
}
