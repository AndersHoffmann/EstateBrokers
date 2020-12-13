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

        public void OpenHouseDistribution(decimal realterIdOne, decimal realtorIdTwo, decimal realtorIdThree)
        {

            OpenHouseRequestModel openHouseRequestModel = new OpenHouseRequestModel();

            openHouseRequestModel.RealtorId1 = Convert.ToInt32(realterIdOne);
            openHouseRequestModel.RealtorId2 = Convert.ToInt32(realtorIdTwo);
            openHouseRequestModel.RealtorId3 = Convert.ToInt32(realtorIdThree);

            OpenHouseInput.RunOpenHouse(openHouseRequestModel);

        }


    }
}
