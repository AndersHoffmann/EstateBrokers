using Gateways;
using Database;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseCases.OpenHouse
{
    public class OpenHouseLogic : IOpenHouseInput
    {
        public IOpenHouseOutput OpenHouseOutput { get; set; }

        public OpenHouseLogic()
        {

        }

        public OpenHouseLogic(IOpenHouseOutput openHouseOutput)
        {
            OpenHouseOutput = openHouseOutput;
        }
            
        public void RunOpenHouse(OpenHouseRequestModel openHouseRequestModel)
        {
            ICaseCRUD caseCRUD = new CaseCRUD();
            List<Entities.Realtor> realtorList = AssignRealtors(openHouseRequestModel.Realtor1, openHouseRequestModel.Realtor2, openHouseRequestModel.Realtor3);
            List<List<int>> CaseIDLists = new List<List<int>>();
            List<Entities.Case> Cases = caseCRUD.ReadAPreDefinedNumberOfCasesWithNoRealtor(18);

            Random rnd = new Random();
            bool success;


            DistributeCases(out CaseIDLists, out success, Cases, rnd, realtorList);
            AssignCases(CaseIDLists, realtorList[0].RealtorID, realtorList[1].RealtorID, realtorList[2].RealtorID);
            OpenHouseReturn(CaseIDLists, success);
            
        }
        public void DistributeCases(out List<List<int>> CaseIDLists, out bool Success, List<Entities.Case> Cases, Random rnd, List<Entities.Realtor> realtorList)
        {
            List<List<int>> tempIDList = new List<List<int>>();

            if (CheckIfNumberOFCasesIsValid(Cases.Count) == true)
            {
                for (int i = 1; i < Cases.Count; i++)
                {
                    List<Entities.Realtor> tempArray = realtorList.OrderBy(x => rnd.Next()).ToList();
                    Cases[i].Realtor = tempArray[i % 3];
                    tempIDList[i % 3].Add(Cases[i].CaseID);
                }
                CaseIDLists = tempIDList;
                Success = true;
            }
            else
            {
                Success = false;
                CaseIDLists = tempIDList;
            }
        }
        public void AssignCases(List<List<int>> CaseIDLists, int RealtorID1, int RealtorID2, int RealtorID3)
        {
            ICaseCRUD caseCRUD = new CaseCRUD();
            IRealtorCRUD realtorCRUD = new RealtorCRUD(); 
            foreach (var item in CaseIDLists[0])
            {
                Entities.Case workingCase = caseCRUD.ReadCase(item);
                caseCRUD.UpdateCase(item, workingCase.CreationDate, workingCase.ClosedDate.GetValueOrDefault(), workingCase.Price, realtorCRUD.ReadRealtor(RealtorID1));
            }
            foreach (var item in CaseIDLists[1])
            {
                Entities.Case workingCase = caseCRUD.ReadCase(item);
                caseCRUD.UpdateCase(item, workingCase.CreationDate, workingCase.ClosedDate.GetValueOrDefault(), workingCase.Price, realtorCRUD.ReadRealtor(RealtorID2));
            }
            foreach (var item in CaseIDLists[2])
            {
                Entities.Case workingCase = caseCRUD.ReadCase(item);
                caseCRUD.UpdateCase(item, workingCase.CreationDate, workingCase.ClosedDate.GetValueOrDefault(), workingCase.Price, realtorCRUD.ReadRealtor(RealtorID3));
            }
        }
        public void OpenHouseReturn(List<List<int>> CaseIDLists, bool success)
        {
            OpenHouseResponseModel response = new OpenHouseResponseModel();

            response.Realtor1Cases = CaseIDLists[0];
            response.Realtor2Cases = CaseIDLists[1];
            response.Realtor3Cases = CaseIDLists[2];
            response.HousesAssignedSuccessfully = success;
            OpenHouseOutput.ReturnSuccessStateAndAsssignedPropertyIDs(response);
        }
        public List<Entities.Realtor> AssignRealtors(Entities.Realtor realtor1, Entities.Realtor realtor2, Entities.Realtor realtor3)
        {
            List<Entities.Realtor> realtorList = new List<Entities.Realtor>();
            realtorList[0] = realtor1;
            realtorList[1] = realtor2;
            realtorList[2] = realtor3;
            return realtorList;
        }
        public bool CheckIfNumberOFCasesIsValid(int caseCount)
        {
            if (caseCount == 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

