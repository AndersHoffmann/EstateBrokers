using System;
using UseCases.EvaluateProperty;
using UseCases.Statistics;

namespace Controllers
{
    public class EvaluatePropertyController
    {
        //Public for test
        IEvaluatePropertyInput _evaluatePropertyInput;

        public EvaluatePropertyController(IEvaluatePropertyInput evaluatePropertyInput)
        {
            _evaluatePropertyInput = evaluatePropertyInput;

        }

        public void EstimateCode(decimal squareMeters, int houseCondition, bool isDesignerHouse, bool hasGarden, bool hasBasement, bool hasGarage)
        {
            EvaluatePropertyRequestModel request = new EvaluatePropertyRequestModel();

            request.SquareMeter = Convert.ToInt32(squareMeters);
            request.HouseCondition = houseCondition;
            request.IsDesignerHouse = isDesignerHouse;
            request.HasGarden = hasGarden;
            request.HasBasement = hasBasement;
            request.HasGarage = hasGarage;

            _evaluatePropertyInput.MakeEvaluation(request);
        }

    }
}
