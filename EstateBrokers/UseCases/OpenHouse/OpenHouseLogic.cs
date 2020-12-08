using Database;
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
            IRealtorCRUD realtorcrud = new RealtorCRUD();

            List<Entities.Realtor> realtorList = new List<Entities.Realtor>();

            bool success;

            realtorList.Add(realtorcrud.ReadRealtor(openHouseRequestModel.RealtorId1));
            realtorList.Add(realtorcrud.ReadRealtor(openHouseRequestModel.RealtorId2));
            realtorList.Add(realtorcrud.ReadRealtor(openHouseRequestModel.RealtorId3));


            OpenHouseResponseModel response = new OpenHouseResponseModel();
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
                response.Realtor2Cases = CaseIDLists[1];
                response.Realtor3Cases = CaseIDLists[2];
                response.HousesAssignedSuccessfully = success;
                OpenHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
            }
        }

    }
}

