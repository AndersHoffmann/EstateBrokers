using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.EvaluateProperty
{
    public interface IEvaluatePropertyOutput
    {
        public void DisplayPropertyEvaluation(EvaluatePropertyResponseModel evaluatePropertyResponseModel);

    }
}
