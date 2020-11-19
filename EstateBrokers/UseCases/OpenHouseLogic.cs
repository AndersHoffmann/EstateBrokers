using Database;
using Entities;
using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    class OpenHouseLogic
    {
        public void RunOpenHouse(List<Realtor> realtorList, List<Case> distributionList)
        {
            ICaseCRUD crud = new CaseCRUD();
            SingleFunctionMethods SFM = new SingleFunctionMethods();

            Random rnd = new Random();
            if (realtorList.Count == 3)
            {
                int reset = 0;
                for (int i = 1; i < distributionList.Count + 1; i++)
                {
                    if (i % 3 == 0)
                    {
                        List<Realtor> tempArray = realtorList.OrderBy(x => rnd.Next()).ToList();
                        reset = 0;
                    }

                    crud.UpdateCase(distributionList[i].CaseID, distributionList[i].CreationDate, distributionList[i].ClosedDate, distributionList[i].Price, distributionList[i].Realtor);
              
                    SFM.SaveChanges();

                }
            }
        }
    }
}
