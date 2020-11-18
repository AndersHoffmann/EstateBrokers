using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class SimulatedBankPaymentCalculator : IBank
    {

        public double PaymentCalculator(double input, int LoanDuration )
        {
            double result = (input * 1.15) / LoanDuration;

            return result;
        }
    }
}
