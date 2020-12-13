using System;
using UseCases.PaymentCalculator;
namespace Controllers
{
    public class PaymentCalculatorController
    {
        IPaymentCalculatorInput PaymentCalculatorInput;

        public PaymentCalculatorController(IPaymentCalculatorInput paymentCalculatorInput)
        {
            PaymentCalculatorInput = paymentCalculatorInput;
        }

        public void CalculatePayment(decimal price, decimal loanDuration)
        {
            PaymentCalculatorRequestModel request = new PaymentCalculatorRequestModel();

            request.Price = Convert.ToDouble(price);
            request.LoanDuration = Convert.ToInt32(loanDuration);

            PaymentCalculatorInput.CalculatePayment(request);


        }

    }
}
