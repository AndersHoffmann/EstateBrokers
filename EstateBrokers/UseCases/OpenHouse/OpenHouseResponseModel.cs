using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.OpenHouse
{
    public class OpenHouseResponseModel
    {
        public bool HousesAssignedSuccessfully { get; set; }

        public List<int> Realtor1Cases { get; set; }
        public List<int> Realtor2Cases { get; set; }
        public List<int> Realtor3Cases { get; set; }

    }
}
