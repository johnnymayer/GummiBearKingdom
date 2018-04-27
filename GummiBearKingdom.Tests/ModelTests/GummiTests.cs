using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Tests
{
    [TestClass]
    public class GummiTests
    {
        
        [TestMethod]
        public void GetProperties_ReturnsData_All()
        {
            //Arrange
            Gummi newGummi = new Gummi("Redd", "A strong red Gummi", 1);

            //Act
            int idResult = newGummi.GummiId;
            string nameResult = newGummi.Name;
            int priceResult = newGummi.Price;
            string descriptionResult = newGummi.Description;

            //Assert
            Assert.AreEqual(0, idResult);
            Assert.AreEqual("Redd", nameResult);
            Assert.AreEqual(1, priceResult);
            Assert.AreEqual("A strong red Gummi", descriptionResult);

        }
    }
}
