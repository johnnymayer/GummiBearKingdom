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
    public class GummisControllerTest
    {
        Mock<IGummiRepository> mock = new Mock<IGummiRepository>();

        private void DbSetup()
        {
            mock.Setup(m => m.Gummis).Returns(new Gummi[]
            {
                new Gummi {GummiId = 1, Description = "A new red gummi" },
                new Gummi {GummiId = 2, Description = "A new blue gummi"},
                new Gummi {GummiId = 3, Description = "A new green gummi"}
            }.AsQueryable());
        }

        [TestMethod]
        public void Controller_GetViewResultIndex_IActionResult()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_GetViewResultDetails_IActionResult()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Details(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_GetViewResultCreate_IActionResult()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsInstanceOfType(result, typeof(IActionResult));
        }

        [TestMethod]
        public void Controller_HttpPostCreate_Creates()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Create();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ViewResult));
        }

        [TestMethod]
        public void Controller_GetViewEdit_Edits()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Edit(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_HttpPostEdit_Edits()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Edit(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_GetViewDelete_Deletes()
        {
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Delete(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_HttpPostDeleteConfirm_Confirms()
        {
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.DeleteConfirmed(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

    }
}
