using System.Linq;
using UseCases.OpenHouse;
using ViewModels;

namespace Presenters
{
    public partial class OpenHousePresenter : IOpenHouseOutput
    {
        public IOpenHouseFrontEnd FrontEnd { get; set; }

        public OpenHousePresenter(IOpenHouseFrontEnd frontEnd)
        {
            FrontEnd = frontEnd;
        }



        public void ReturnSuccessStateAndAsssignedPropertyIDs(OpenHouseResponseModel response)
        {
            OpenHouseViewModel openHouseViewModel = new OpenHouseViewModel();

            openHouseViewModel.HousesAssignedSuccessfully = response.HousesAssignedSuccessfully;
            openHouseViewModel.Realtor1Cases = response.Realtor1Cases.Select(c => c.ToString()).ToList();
            openHouseViewModel.Realtor2Cases = response.Realtor2Cases.Select(c => c.ToString()).ToList();
            openHouseViewModel.Realtor3Cases = response.Realtor3Cases.Select(c => c.ToString()).ToList();

            FrontEnd.ListsForCaseAssign(openHouseViewModel);
        }
    }
}
