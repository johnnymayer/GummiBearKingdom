using GummiBearKingdom.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GummiBearKingdom.Tests.Models
{
    [TestClass]
    public class GummiBearKingdomDbContextTests
    {
        private MockRepository mockRepository;



        [TestInitialize]
        public void TestInitialize()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        [TestCleanup]
        public void TestCleanup()
        {
            this.mockRepository.VerifyAll();
        }
    }
}
