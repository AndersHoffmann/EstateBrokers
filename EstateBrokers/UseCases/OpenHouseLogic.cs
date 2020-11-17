using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UseCases
{
    class OpenHouseLogic
    {
        public void RunOpenHouse(List<Realtor> realtorList, List<Property> distributionList)
        {
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

                    //Crud code here
                    
                }
            }
        }
    }
}
