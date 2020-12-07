using Gateways;

namespace Bank
{
    public class SimulatedBankPaymentCalculator : IBank
    {
        //Recieves the balance of the loan as well as the running time in months and spits out a value 115% of the original divided by the number of months
        public double PaymentCalculator(double price, int LoanDuration)
        {
            double result = (price * 1.15) / LoanDuration;

            return result;
        }
    }
}
