using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class SimulatedBankPaymentCalculator : IBank
    {
        //Recieves the balance of the loan as well as the running time in months and spits out a value 115% of the original divided by the number of months
        public double PaymentCalculator(double input, int LoanDuration )
        {
            double result = (input * 1.15) / LoanDuration;

            return result;
        }
    }
}
