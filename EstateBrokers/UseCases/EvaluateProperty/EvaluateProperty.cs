namespace UseCases.EvaluateProperty
{
    public class EvaluateProperty : IEvaluatePropertyInput

    {

        public IEvaluatePropertyOutput EvaluatePropertyOutput { get; set; }

        public EvaluateProperty(IEvaluatePropertyOutput evaluatePropertyOutput)
        {
            EvaluatePropertyOutput = evaluatePropertyOutput;
        }



        public void MakeEvaluation(EvaluatePropertyRequestModel evaluatePropertyRequestModel)
        {
            var response = new EvaluatePropertyResponseModel();

            double baseSquareMeterPrice = 5000;

            double conditionMultiplier = evaluatePropertyRequestModel.HouseCondition;

            baseSquareMeterPrice *= 1 + conditionMultiplier / 20;

            baseSquareMeterPrice = evaluatePropertyRequestModel.IsDesignerHouse ? baseSquareMeterPrice * 1.6 : baseSquareMeterPrice;
            baseSquareMeterPrice = evaluatePropertyRequestModel.HasBasement ? baseSquareMeterPrice * 1.2 : baseSquareMeterPrice;
            baseSquareMeterPrice = evaluatePropertyRequestModel.HasGarden ? baseSquareMeterPrice * 1.2 : baseSquareMeterPrice;
            baseSquareMeterPrice = evaluatePropertyRequestModel.HasGarage ? baseSquareMeterPrice * 1.1 : baseSquareMeterPrice;

            double evaluation = baseSquareMeterPrice * evaluatePropertyRequestModel.SquareMeter;

            response.PropertyValuation = evaluation;
            EvaluatePropertyOutput.DisplayPropertyEvaluation(response);
        }
    }
}
