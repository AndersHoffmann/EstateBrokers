using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseCases.OpenHouse
{
    public class OpenHouseLogic : IOpenHouseInput
    {
        public IOpenHouseOutput OpenHouseOutput { get; set; }

        public OpenHouseLogic(IOpenHouseOutput openHouseOutput)
        {
            OpenHouseOutput = openHouseOutput;
        }
        public void RunOpenHouse(OpenHouseRequestModel openHouseRequestModel)
        {

            ICaseCRUD caseCRUD = new CaseCRUD();
            List<Entities.Realtor> realtorList = new List<Entities.Realtor>();
            bool success;
            realtorList[0] = openHouseRequestModel.Realtor1;
            realtorList[1] = openHouseRequestModel.Realtor2;
            realtorList[2] = openHouseRequestModel.Realtor3;

           
            Random rnd = new Random();
            List<List<int>> CaseIDLists = new List<List<int>>();
            List<Entities.Case> Cases = caseCRUD.ReadAPreDefinedNumberOfCasesWithNoRealtor(18);

            if (CheckIfNumberOFCasesIsValid(Cases.Count) == false)
            {
            success = false;
            response.HousesAssignedSuccessfully = success;
            OpenHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
            }
            if (CheckIfNumberOFCasesIsValid(Cases.Count) == true)
            {
                for (int i = 1; i < Cases.Count; i++)
                {

                    List<Entities.Realtor> tempArray = realtorList.OrderBy(x => rnd.Next()).ToList();

                    Cases[i].Realtor = tempArray[i % 3];
                    CaseIDLists[i % 3].Add(Cases[i].CaseID);
                }
            success = true;
          
            response.Realtor1Cases = CaseIDLists[0];
            response.Realtor1Cases = CaseIDLists[1];
            response.Realtor1Cases = CaseIDLists[2];
            response.HousesAssignedSuccessfully = success;
            OpenHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
            }     
        }
        
    }
}

