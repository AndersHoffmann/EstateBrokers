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
        ICaseCRUD _caseCRUD;
        public CalculateAverageWithIntegerInput(ICaseCRUD caseCRUD)
        {
            _caseCRUD = caseCRUD;
        }
        public double Calculate(int input)
        {
          

            List<Entities.Case> cases = _caseCRUD.ReadCases(input);
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
