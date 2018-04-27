using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBearKingdom.Models;

namespace GummiBearKingdom.Tests
{
    [TestClass]
    public class GummiTests
    {
        
        [TestMethod]
        public void GummiGetter_ReturnsData_All()
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

        [TestMethod]
        public void GummiSetter_SetsData_All()
        {
            //Arrange
            Gummi newGummi = new Gummi("Redd", "A strong red Gummi", 1);

            //Act
            newGummi.Name = "Red Name";
            newGummi.Description = "Red Description";
            newGummi.Price = 2;

            //Assert
            Assert.AreEqual("Red Name", newGummi.Name);
            Assert.AreEqual("Red Description", newGummi.Description);
            Assert.AreEqual(2, newGummi.Price);
        }

        [TestMethod]
        public void GummiConstructor_ReturnsGummi_newGummi()
        {
            //Arrange
            Gummi newGummi = new Gummi("Redd", "A strong red Gummi", 1);

            //Assert
            Assert.AreEqual("Redd", newGummi.Name);
        }


    }
}
