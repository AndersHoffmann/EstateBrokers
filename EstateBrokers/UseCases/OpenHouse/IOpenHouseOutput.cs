using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.OpenHouse
{
    public interface IOpenHouseOutput
    {
        public void ReturnSuccessStateAndAsssignedPropertyIDs(OpenHouseResponseModel openHouseResponseModel);
    }
}
