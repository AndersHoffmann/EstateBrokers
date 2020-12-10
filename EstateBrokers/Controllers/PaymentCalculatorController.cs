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

        public void CalculatePayment(string price, string loanDuration)
        {
            PaymentCalculatorRequestModel request = new PaymentCalculatorRequestModel();

            request.Price = Double.Parse(price);
            request.LoanDuration = Int32.Parse(loanDuration);

            PaymentCalculatorInput.CalculatePayment(request);


        }

    }
}
