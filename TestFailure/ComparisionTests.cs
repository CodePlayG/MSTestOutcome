using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest
{
    [TestClass]
   public class ComparisionTests:TestSetup
    {
        [TestMethod]
        public void VerifyTwoCities()
        {
            var city1 = "Bangalore";
            var city2 = "Bangalore";
            Assert.AreEqual(city1, city2);
        }
        [TestMethod]
        public void VerifyTwoNames()
        {
            var name1 = "Abcd";
            var name2 = "Xyz";
            Assert.AreEqual(name1, name2);
        }
    }
}
