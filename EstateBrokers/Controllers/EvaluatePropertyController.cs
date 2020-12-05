using System;
using UseCases.OpenHouse;
using UseCases.Statistics;

namespace Controllers
{
    public class EvaluatePropertyController
    {
        private static IEvaluatePropertyInput _evaluatePropertyInput;

        public EvaluatePropertyController(IEvaluatePropertyInput evaluatePropertyInput)
        {
            _evaluatePropertyInput = evaluatePropertyInput;
            
        }
       
        public void EstimateCode(int squareMeters, int houseCondition, bool isDesignerHouse, bool hasGarden, bool hasBasement, bool hasGarage)
        {
            EvaluatePropertyRequestModel request = new EvaluatePropertyRequestModel();

            request.SquareMeter = squareMeters;
            request.HouseCondition = houseCondition;
            request.IsDesignerHouse = isDesignerHouse;
            request.HasGarden = hasGarden;
            request.HasBasement = hasBasement;
            request.HasGarden = hasGarage;

            _evaluatePropertyInput.MakeEvaluation(request);
        }
 
    }
}
