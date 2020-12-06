﻿using UseCases.EvaluateProperty;
using ViewModels;


namespace Presenters

{

    public partial class EvaluatePropertyPresenter : IEvaluatePropertyOutput
    {

        public IEvaluatePropertyFrontEnd FrontEnd { get; set; }

        public EvaluatePropertyViewModel evaluatePropertyViewModel;

        public EvaluatePropertyPresenter(IEvaluatePropertyFrontEnd evaluatePropertyFrontEnd)
        {
            evaluatePropertyViewModel = new EvaluatePropertyViewModel();
            FrontEnd = evaluatePropertyFrontEnd;
        }

        public void DisplayPropertyEvaluation(EvaluatePropertyResponseModel evaluatePropertyResponseModel)
        {
            evaluatePropertyViewModel.PropertyValuation = evaluatePropertyResponseModel.PropertyValuation.ToString();

            FrontEnd.UpdatePropertyValuationField(evaluatePropertyViewModel);
        }
    }
}
