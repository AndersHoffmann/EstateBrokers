
using Entities;
using Entities.Objects;
using Gateways;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UseCases.EvaluateProperty
{
    public class EvaluateProperty : IEvaluatePropertyInput

    {

        IEvaluatePropertyOutput EvaluatePropertyOutput { get; set; }

        public EvaluateProperty(IEvaluatePropertyOutput evaluatePropertyOutput)
        {
            EvaluatePropertyOutput = evaluatePropertyOutput;
        }

        public EvaluatePropertyResponseModel MakeValuation(EvaluatePropertyRequestModel evaluatePropertyRequestModel)
        {

            var property = new Property();
            property.PropertyValuation = new Valuation(
                evaluatePropertyRequestModel.SquareMeter,
                evaluatePropertyRequestModel.HouseCondition,
                evaluatePropertyRequestModel.IsDesignerHouse,
                evaluatePropertyRequestModel.HasGarden,
                evaluatePropertyRequestModel.HasBasement,
                evaluatePropertyRequestModel.HasGarage);

            var response = new EvaluatePropertyResponseModel();

            response.PropertyValuation = property.PropertyValuation.CalculateValuation();

            EvaluatePropertyOutput.DisplayPropertyValuation(response);
            return response;

        }
    }
}

