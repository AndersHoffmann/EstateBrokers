using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseCases.OpenHouse
{
    public class EvaluateProperty : IEvaluatePropertyInput
    {
        public IEvaluatePropertyOutput OpenHouseOutput { get; set; }

        public EvaluateProperty(IEvaluatePropertyOutput openHouseOutput)
        {
            OpenHouseOutput = openHouseOutput;
        }
        public void RunOpenHouse(EvaluatePropertyRequestModel openHouseRequestModel)
        {

            ICaseCRUD caseCRUD = new CaseCRUD();
            List<Entities.Realtor> realtorList = new List<Entities.Realtor>();
            bool success;
            realtorList[0] = openHouseRequestModel.Realtor1;
            realtorList[1] = openHouseRequestModel.Realtor2;
            realtorList[2] = openHouseRequestModel.Realtor3;

            EvaluatePropertyResponseModel response = new EvaluatePropertyResponseModel();
            Random rnd = new Random();
            List<List<int>> CaseIDLists = new List<List<int>>();
            List<Entities.Case> Cases = caseCRUD.ReadAPreDefinedNumberOfCasesWithNoRealtor(18);

            if (Cases.Count != 18)
            {
                success = false;
                response.HousesAssignedSuccessfully = success;
                OpenHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
            }
            else
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

