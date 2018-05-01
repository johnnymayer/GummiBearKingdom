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

namespace GummiBearKingdom.Tests
{
    [TestClass]
    public class GummisControllerTest
    {
        Mock<IGummiRepository> mock = new Mock<IGummiRepository>();
        public void DbSetup()
        {
            mock.Setup(m => m.Gummis).Returns(new Gummi[]
            {
                new Gummi {GummiId = 1, Description = "A new red gummi" },
                new Gummi {GummiId = 2, Description = "A new blue gummi"},
                new Gummi {GummiId = 3, Description = "A new green gummi"}
            }.AsQueryable()); 
        }

        [TestMethod]
        public void Mock_GetViewResultIndex_ActionResult()
        {
            //Arrange
            DbSetup();
            GummisController controller = new GummisController(mock.Object);

            //Act
            var result = controller.Index();

            //Assert
            Assert.IsInstanceOfType(result, typeof(ActionResult));
        }


    }
}
