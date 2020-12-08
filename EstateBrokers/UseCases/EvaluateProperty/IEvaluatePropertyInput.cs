using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.EvaluateProperty
{
    public interface IEvaluatePropertyInput
    {
        public EvaluatePropertyResponseModel MakeEvaluation(EvaluatePropertyRequestModel evaluatePropertyRequestModel);

    }
}
