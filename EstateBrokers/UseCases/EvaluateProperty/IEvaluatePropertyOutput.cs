using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.OpenHouse
{
    public interface IEvaluatePropertyOutput
    {
        public void ReturnSuccessStateAndAsssignedPropertyIDs(EvaluatePropertyResponseModel openHouseResponseModel);
    }
}
