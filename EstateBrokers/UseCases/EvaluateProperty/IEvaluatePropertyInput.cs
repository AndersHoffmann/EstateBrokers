using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.EvaluateProperty
{
    public interface IEvaluatePropertyInput
    {
        public void MakeEvaluation(EvaluatePropertyRequestModel evaluatePropertyRequestModel);

    }
}
