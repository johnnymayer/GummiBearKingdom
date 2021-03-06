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
    public class ReviewsControllerTests
    {
        Mock<IReviewRepository> mock = new Mock<IReviewRepository>();

        private void DbSetup()
        {
            mock.Setup(m => m.Reviews).Returns(new Review[]
            {
                new Review {Author = "Don", Content = "Hate it." },
                new Review {Author = "Ron", Content = "Like it." },
                new Review {Author = "John", Content = "Love it." },
            }.AsQueryable());
        }

        [TestMethod]
        public void Controller_GetViewResultIndex_IActionResult()
        {
            //Arrange
            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);

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
            ReviewsController controller = new ReviewsController(mock.Object);

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
            ReviewsController controller = new ReviewsController(mock.Object);

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
            ReviewsController controller = new ReviewsController(mock.Object);

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
            ReviewsController controller = new ReviewsController(mock.Object);

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
            ReviewsController controller = new ReviewsController(mock.Object);

            //Act
            var result = controller.Edit(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_GetViewDelete_Deletes()
        {
            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);

            //Act
            var result = controller.Delete(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }

        [TestMethod]
        public void Controller_HttpPostDeleteConfirm_Confirms()
        {
            DbSetup();
            ReviewsController controller = new ReviewsController(mock.Object);

            //Act
            var result = controller.DeleteConfirmed(1);

            //Assert
            Assert.IsInstanceOfType(result, typeof(Task<IActionResult>));
        }
    }

}

