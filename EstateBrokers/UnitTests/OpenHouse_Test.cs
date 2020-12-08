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
         List<Case> Cases = new List<Case>();
         List<Realtor> realtors = new List<Realtor>();
         

        private void FillLists()
        {
            Cases.Clear();
            realtors.Clear();

            for (int i = 0; i < 18; i++)
            {
                Cases.Add(new Case());
                Cases[i].CaseID = i;
            }
            for (int i = 0; i < 3; i++)
            {
                realtors.Add(new Realtor());
                realtors[i].RealtorID = i;
            }
        }

        [TestMethod()]
        public void Number_Of_Properties_Should_Be_Equal()
        {
            //Arrange
            FillLists();
            OpenHouseLogic openHouseLogic = new OpenHouseLogic();

            //Act
            openHouseLogic.RunOpenHouse(realtors, Cases);

            int realtorOne = Cases.Count(s => s.Realtor.RealtorID == 0);
            int realtorTwo = Cases.Count(s => s.Realtor.RealtorID == 1);
            int realtorThree = Cases.Count(s => s.Realtor.RealtorID == 2);

            //Assert
            Assert.AreEqual(realtorOne, realtorOne, realtorThree);
        }
    }
}
