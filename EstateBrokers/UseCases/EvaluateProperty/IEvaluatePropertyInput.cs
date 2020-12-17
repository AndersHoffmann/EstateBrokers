using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.EvaluateProperty
{
    public interface IEvaluatePropertyInput
    {
        public EvaluatePropertyResponseModel MakeValuation(EvaluatePropertyRequestModel evaluatePropertyRequestModel);

    }
}
