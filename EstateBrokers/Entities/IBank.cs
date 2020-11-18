using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    interface IBank
    {
        public double PaymentCalculator(double input, int LoanDuration);
    }
}
