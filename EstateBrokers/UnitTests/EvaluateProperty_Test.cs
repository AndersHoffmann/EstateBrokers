using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UseCases.OpenHouse;
using Presenters;

namespace UnitTests
{
    
    [TestClass]
    public class EvaluateProperty_Test
    {
        [TestMethod()]
        public void MakeEvaluation()
        {
            // Arrange

            var requestModel = new EvaluatePropertyRequestModel();
            requestModel.SquareMeter = 100;
            requestModel.HouseCondition = 10;
            requestModel.IsDesignerHouse = true;
            requestModel.HasGarden = true;
            requestModel.HasBasement = false;
            requestModel.HasGarage = true;

            //Act

            var evaluateOutput = new EvaluatePropertyPresenter();
            var evaluateProperty = new EvaluateProperty(evaluateOutput);

            evaluateProperty.MakeEvaluation(requestModel);

            //Assert

            Assert.AreEqual(evaluateOutput.evaluatePropertyViewModel.PropertyValuation, "1848000");
        }

    }
}
