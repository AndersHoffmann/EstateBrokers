﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases
{
    class CalculateMonthlyPayment
    {
        public double CalculatePayment(double input, int LoanPeriodMonths)
        {
            IBank bank = new SimulatedBankPaymentCalculator();
            {
                return bank.PaymentCalculator(input, LoanPeriodMonths);
            }
        }
    }
}