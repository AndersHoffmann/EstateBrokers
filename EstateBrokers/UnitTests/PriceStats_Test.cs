using Entities;
using Gateways;
using UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UseCases.OpenHouse;
using GUI;
using Controllers;
using UseCases.EvaluateProperty;

namespace UnitTests
{
    [TestClass]
    public class PriceStats_Test
    {
        [TestMethod()]
        public void Output_Price_Is_Not_Exactly_5000_Times_Input_House_Area()
        {
            //Arrange
            PropertyValuationPage propertyValuationPage = new PropertyValuationPage();
            EvaluatePropertyController evaluatePropertyController = DependencyInjectionContainer.GetEvaluatePropertyController(propertyValuationPage);

            EvaluatePropertyRequestModel e = new EvaluatePropertyRequestModel();

            e.HasBasement = false;
            e.HasGarage = false;
            e.HasGarden = false;
            e.IsDesignerHouse = false;
            e.HouseCondition = 1;
            e.SquareMeter = 50;

            //Act
            IEvaluatePropertyInput ip = EvaluatePropertyController._evaluatePropertyInput;
            EvaluatePropertyResponseModel result = ip.MakeEvaluation(e);
            double estimatedValue = result.PropertyValuation;

            //Assert
            Assert.AreNotEqual(estimatedValue, e.SquareMeter * 5000);
        }
        [TestMethod()]
        public void Output_Price_Is_Less_Than_Ten_Percent_Higher_than_Input_Area_Times_5000()
        {
            //Arrange
            PropertyValuationPage propertyValuationPage = new PropertyValuationPage();
            EvaluatePropertyController evaluatePropertyController = DependencyInjectionContainer.GetEvaluatePropertyController(propertyValuationPage);

            EvaluatePropertyRequestModel e = new EvaluatePropertyRequestModel();


            e.HasBasement = false;
            e.HasGarage = false;
            e.HasGarden = false;
            e.IsDesignerHouse = false;
            e.HouseCondition = 1;
            e.SquareMeter = 50;

            //Act
            IEvaluatePropertyInput ip = EvaluatePropertyController._evaluatePropertyInput;
            EvaluatePropertyResponseModel result = ip.MakeEvaluation(e);
            double estimatedValue = result.PropertyValuation;

            if (estimatedValue  > (e.SquareMeter * 5000) * 1.1)

  
            //Assert
            Assert.IsFalse(estimatedValue > (e.SquareMeter * 5000) * 1.1);
        }
        [TestMethod()]
        public void Output_Price_Is_Exactly_()
        {
            //Arrange
            PropertyValuationPage propertyValuationPage = new PropertyValuationPage();
            EvaluatePropertyController evaluatePropertyController = DependencyInjectionContainer.GetEvaluatePropertyController(propertyValuationPage);

            EvaluatePropertyRequestModel e = new EvaluatePropertyRequestModel();
            IEvaluatePropertyInput ip = EvaluatePropertyController._evaluatePropertyInput;
            EvaluatePropertyResponseModel result = ip.MakeEvaluation(e);
            double estimatedValue = result.PropertyValuation;

            e.HasBasement = false;
            e.HasGarage = true;
            e.HasGarden = false;
            e.IsDesignerHouse = false;
            e.HouseCondition = 8;
            e.SquareMeter = 73;

            //Act
            double finalPrice = (e.SquareMeter * (1 + 8 / 20)) * 1.1;

            //Assert
            Assert.AreEqual(finalPrice, estimatedValue);
        }

    }
}
