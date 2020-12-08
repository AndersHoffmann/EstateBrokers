using Entities;
using Gateways;
using UseCases;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using UseCases.OpenHouse;

namespace UnitTests
{
    [TestClass]
    public class OpenHouse_Test
    {
        [TestMethod()]
        public void If_Input_Is_Eighteen_Method_Shoud_Return_True()
        {
            //Arrange
         
            OpenHouseLogic openHouseLogic = new OpenHouseLogic();

            //Act
           bool result = openHouseLogic.CheckIfNumberOFCasesIsValid(18);

            //Assert
            Assert.IsTrue(result);
            
        }
        [TestMethod()]
        public void If_Input_Is_Not_Eighteen_Method_Shoud_return_False()
        {
            //Arrange

            OpenHouseLogic openHouseLogic = new OpenHouseLogic();

            //Act
            bool result = openHouseLogic.CheckIfNumberOFCasesIsValid(15);

            //Assert
            Assert.IsTrue(result);

        }
    }
}
