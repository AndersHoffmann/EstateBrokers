using Database;
using Entities;
using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    public class OpenHouseLogic
    {
        public List<Entities.Case> RunOpenHouse(List<Entities.Realtor> realtorList, List<Entities.Case> distributionList)
        {
            List<Entities.Case> Cases = new List<Entities.Case>();
            Random rnd = new Random();

                for (int i = 1; i < distributionList.Count + 1; i++)
                {
                    if (i % 3 == 0)
                    {
                        List<Entities.Realtor> tempArray = realtorList.OrderBy(x => rnd.Next()).ToList();
                  
                    }

                Cases.Add(distributionList[i]);
                }
            return Cases;
        }
        public void SaveOpenHouseChanges(List<Entities.Realtor> realtorList, List<Entities.Case> distributionList)
        {
            List <Entities.Case>  Cases = RunOpenHouse(realtorList, distributionList);
            ICaseCRUD crud = new CaseCRUD();
            foreach (var item in Cases)
            {
                crud.CreateCase(item.CreationDate, item.Price, item.Realtor);
            }           
        }
    }
}

