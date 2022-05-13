using Microsoft.VisualStudio.TestTools.UnitTesting;
using Hello;

namespace HelloWorldTests
{
    [TestClass]
    public class AutogradingTests
    {
        [TestMethod]
        public void TestSayHello()
        {
            Assert.AreEqual(SayHelloClass.SayHello(), "Hello, World!");
        }
    }
}
