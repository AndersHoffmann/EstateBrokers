using Database;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    [TestClass]
    public class OpenHouse_Test
    {
         List<Property> properties = new List<Property>();
         List<Realtor> realtors = new List<Realtor>();
         OpenHouse OH = new OpenHouse();

        private void FillLists()
        {
            properties.Clear();
            realtors.Clear();

            for (int i = 0; i < 18; i++)
            {
                properties.Add(new Property());
                properties[i].PropertyID = i;
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
            FillLists();

            OH.RunOpenHouse(realtors, properties);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(6, realtors[i].PropertyResponsibility.Count);
            }
          
        }
        [TestMethod()]
        public void Method()
        {
            FillLists();

            OH.RunOpenHouse(realtors, properties);
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(6, realtors[i].PropertyResponsibility.Count);
            }

        }
    }
}
