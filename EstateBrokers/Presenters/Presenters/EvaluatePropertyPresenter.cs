using UseCases.EvaluateProperty;
using System;
using UseCases.CreateEntry;

using ViewModels;


namespace Presenters

{

    public partial class EvaluatePropertyPresenter : IEvaluatePropertyOutput
    {

        public IEvaluatePropertyFrontEnd FrontEnd { get; set; }

        

        public EvaluatePropertyPresenter(IEvaluatePropertyFrontEnd evaluatePropertyFrontEnd)
        {
            
            FrontEnd = evaluatePropertyFrontEnd;
        }

        public void DisplayPropertyValuation(EvaluatePropertyResponseModel evaluatePropertyResponseModel)
        {
            EvaluatePropertyViewModel evaluatePropertyViewModel = new EvaluatePropertyViewModel();

            evaluatePropertyViewModel.PropertyValuation = evaluatePropertyResponseModel.PropertyValuation.ToString();

            FrontEnd.UpdatePropertyValuationField(evaluatePropertyViewModel);
        }
    }

}
