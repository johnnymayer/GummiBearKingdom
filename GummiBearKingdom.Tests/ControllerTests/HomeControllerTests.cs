using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using GummiBearKingdom.Models;
using GummiBearKingdom.Tests;
using Moq;
using GummiBearKingdom.Models.Repositories;
using GummiBearKingdom.Controllers;
using System.Threading.Tasks;

namespace GummiBearKingdom.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Controller_ReturnsViewIndex_Index()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Controller_ReturnsViewGummi_Gummi()
        {
            //Arrange
            HomeController controller = new HomeController();

            //Act
            var result = controller.Gummis();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));

        }
    }
}
