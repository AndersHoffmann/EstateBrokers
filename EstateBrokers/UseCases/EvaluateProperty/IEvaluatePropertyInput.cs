using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.OpenHouse
{
    public interface IEvaluatePropertyInput
    {
        public void MakeEvaluation(EvaluatePropertyRequestModel evaluatePropertyRequestModel);
    }
}
