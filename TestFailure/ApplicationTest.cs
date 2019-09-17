using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DemoTest

{
    [TestClass]
    public class ApplicationTest: TestSetup
    {      
        [TestMethod]
        public void VerifyAddition(int a, int b)
        {
            //var a = 2;
            //var b = 3;
            Assert.AreEqual(a+b, 4);
        }
        [TestMethod]
        public void VerifySubtraction()
        {
            var a = 3;
           var b = 2;
            Assert.AreEqual(a - b, 1);
        }
        [TestMethod]
        public void CompareTwoStrings()
        {
           var  a = "A";
           var b = "B";
            Assert.AreEqual(a, b);
        }
  
    }
}
