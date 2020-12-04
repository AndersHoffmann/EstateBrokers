using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.OpenHouse
{
    public interface IOpenHouseInput
    {
        public void RunOpenHouse(OpenHouseRequestModel openHouseRequestModel);
    }
}
