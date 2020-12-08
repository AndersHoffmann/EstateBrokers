using Database;
using Entities;
using Gateways;
using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.PrintEntries
{
    public class CalculateAverageWithIntegerInput
    {
        public double Calculate(int input)
        {
            ICaseCRUD crud = new CaseCRUD();

            List<Entities.Case> cases = crud.ReadCases(input);
            double totalPrice = 0;
            int count = 0;
            foreach (var item in cases)
            {
                totalPrice = totalPrice + item.Price;
                count++;
            }
            
            return totalPrice / count;

            
        }
    }
}
