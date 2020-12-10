using System;
using UseCases.OpenHouse;
namespace Controllers
{
    public class OpenHouseController
    {
        IOpenHouseInput OpenHouseInput;

        public OpenHouseController(IOpenHouseInput openHouseInput)
        {
            OpenHouseInput = openHouseInput;

        }

        public void OpenHouseDistribution(string realterIdOne, string realtorIdTwo, string realtorIdThree)
        {

            OpenHouseRequestModel openHouseRequestModel = new OpenHouseRequestModel();

            openHouseRequestModel.RealtorId1 = Int32.Parse(realterIdOne);
            openHouseRequestModel.RealtorId2 = Int32.Parse(realtorIdTwo);
            openHouseRequestModel.RealtorId3 = Int32.Parse(realtorIdThree);

            OpenHouseInput.RunOpenHouse(openHouseRequestModel);

        }


    }
}
