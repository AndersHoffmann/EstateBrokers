using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Database;
using Gateways;
using UseCases;
namespace UnitTests
{
    [TestClass]
    public class CRUD_Test
    {
        [DataRow(DateTime 12-21-1997, double 2000100, Realtor real)]
        [TestMethod()]
        public void Case_Object_Is_Created_And_Readable()(DateTime creationDate, double price, Realtor realtor)
        {
            //Arrange
            var database = new EstateBrokerContext();
            ICaseCRUD crud = new ICaseCRUD();
            //Act
            crud.CreateCase(creationDate, price, realtor);
            database.SaveChanges();
            //Assert
        }

        [TestMethod()]
        public void Case_Object_Is_Deleted()
        {

        }

        [TestMethod()]
        public void Case_Object_Is_Updated()
        {

        }



    }
}
