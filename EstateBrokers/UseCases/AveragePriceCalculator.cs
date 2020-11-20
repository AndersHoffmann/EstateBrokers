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

            List<Case> caseList = crud.ReadCases(postalCode);
            
            return icaseList.Average(a => a.Price);
        }
    }
}
