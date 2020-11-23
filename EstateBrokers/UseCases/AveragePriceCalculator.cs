using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Gateways;
using System.Linq;
namespace UseCases
{
    class AveragePriceCalculator
    {     
        public double CalculateAreaAverage(int postalCode)
        {
            ICaseCRUD crud = new CaseCRUD();

            List<Entities.Case> caseList = crud.ReadCases(postalCode);
            
            return caseList.Average(a => a.Price);
        }
    }
}
