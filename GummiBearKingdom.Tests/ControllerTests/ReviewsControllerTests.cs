using GummiBearKingdom.Controllers;
using GummiBearKingdom.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GummiBearKingdom.Tests.Controllers
{
    [TestClass]
    public class ReviewsControllerTests
    {
        private MockRepository mockRepository;

        private Mock<GummiBearKingdomDbContext> mockGummiBearKingdomDbContext;

        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);

            this.mockGummiBearKingdomDbContext = this.mockRepository.Create<GummiBearKingdomDbContext>();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }
    }
}
