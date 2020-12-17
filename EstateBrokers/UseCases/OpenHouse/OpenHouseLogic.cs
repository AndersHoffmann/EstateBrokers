using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;
namespace UseCases.OpenHouse
{
    public class OpenHouseLogic : IOpenHouseInput
    {
        IOpenHouseOutput _openHouseOutput;
        ICaseCRUD _caseCRUD;
        IRealtorCRUD _realtorCRUD;

        public OpenHouseLogic()
        {

        }

        public OpenHouseLogic(IOpenHouseOutput openHouseOutput, ICaseCRUD caseCRUD, IRealtorCRUD realtorCRUD)
        {
            _openHouseOutput = openHouseOutput;
            _caseCRUD = caseCRUD;
            _realtorCRUD = realtorCRUD;
        }

        public void RunOpenHouse(OpenHouseRequestModel openHouseRequestModel)
        {

            List<Entities.Realtor> realtorList = new List<Entities.Realtor>();

            bool success;

            realtorList.Add(_realtorCRUD.ReadRealtor(openHouseRequestModel.RealtorId1));
            realtorList.Add(_realtorCRUD.ReadRealtor(openHouseRequestModel.RealtorId2));
            realtorList.Add(_realtorCRUD.ReadRealtor(openHouseRequestModel.RealtorId3));


            OpenHouseResponseModel response = new OpenHouseResponseModel();
            Random rnd = new Random();
            List<List<int>> CaseIDLists = new List<List<int>>();
            List<Entities.Case> Cases = _caseCRUD.ReadAPreDefinedNumberOfCasesWithNoRealtor(19);

            CaseIDLists.Add(new List<int>());
            CaseIDLists.Add(new List<int>());
            CaseIDLists.Add(new List<int>());

            if (Cases.Count != 19)
            {
                success = false;
                response.HousesAssignedSuccessfully = success;
                _openHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
            }
            else

                for (int i = 1; i < Cases.Count; i++)
                {
                    List<Entities.Realtor> tempList = realtorList;
                    if (i % 3 == 1)
                    {
                        tempList = realtorList.OrderBy(x => rnd.Next()).ToList();
                    }
                    Cases[i].Realtor = tempList[i % 3];
                    CaseIDLists[i % 3].Add(Cases[i].CaseID);
                }

            success = true;

            response.Realtor1Cases = CaseIDLists[0];
            response.Realtor2Cases = CaseIDLists[1];
            response.Realtor3Cases = CaseIDLists[2];
            response.HousesAssignedSuccessfully = success;
            _openHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
        }
    }

}

