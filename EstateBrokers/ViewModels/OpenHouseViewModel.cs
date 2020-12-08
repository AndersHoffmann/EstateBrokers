using System.Collections.Generic;

namespace ViewModels
{
    public class OpenHouseViewModel
    {

        public bool HousesAssignedSuccessfully { get; set; }

        public List<string> Realtor1Cases { get; set; }
        public List<string> Realtor2Cases { get; set; }
        public List<string> Realtor3Cases { get; set; }

    }
}
