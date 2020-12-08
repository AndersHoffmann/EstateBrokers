using Controllers;
using Presenters;
using System;
using System.Collections.Generic;
using System.Text;
using UseCases.EvaluateProperty;

namespace GUI
{
    public class DependencyInjectionContainer
    {


        public static EvaluatePropertyController GetEvaluatePropertyController(PropertyValuationPage propertyValuationPage)
        {
            IEvaluatePropertyOutput estimatesOutput = new EvaluatePropertyPresenter(propertyValuationPage);
            IEvaluatePropertyInput estimatesInput = new EvaluateProperty(estimatesOutput);

            return new EvaluatePropertyController(estimatesInput);
        }



    }
}
