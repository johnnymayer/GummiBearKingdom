using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GummiBearKingdom.Models;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;

namespace GummiBearKingdom.Tests
{
    [TestClass]
    public class ReviewTests
    {
        [TestMethod]
        public void ReviewGetter_ReturnsData_All()
        {
            //Arrange
            Review newReview = new Review { ReviewId = 0, Author = "John", Content = "Basic gummi review", Rating = 1 };

            //Act
            int reviewId = newReview.ReviewId;
            string author = newReview.Author;
            string content = newReview.Content;
            int rating = newReview.Rating;

            //Assert
            Assert.AreEqual(reviewId, 0);
            Assert.AreEqual(author, "John");
            Assert.AreEqual(content, "Basic gummi review");
            Assert.AreEqual(rating, 1);
        }

        [TestMethod]
        public void ReviewSetter_SetsData_All()
        {
            //Arrange
            Review newReview = new Review { ReviewId = 0, Author = "John", Content = "Basic gummi review", Rating = 1 };

            //Act
            newReview.ReviewId = 1;
            newReview.Author = "Don";
            newReview.Content = "New gummi review";
            newReview.Rating = 2;

            //Assert
            Assert.AreEqual(newReview.ReviewId, 1);
            Assert.AreEqual(newReview.Author, "Don");
            Assert.AreEqual(newReview.Content, "New gummi review");
        }

        [TestMethod]
        public void ReviewConstructor_ReturnsReview_newReview()
        {
            //Arrange
            Review newReview = new Review("Don", "New gummi review");

            //Assert
            Assert.AreEqual("Don", newReview.Author);
            Assert.AreEqual("New gummi review", newReview.Content);
        }

    }
}