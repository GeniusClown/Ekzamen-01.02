using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string password = "SecureP@ssw0rd123";

            bool isvalid = Class1.Validatepassword(password);

            Assert.IsTrue(isvalid);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string password = "SecureP@ssword";

            bool isvalid = Class1.Validatepassword(password);

            Assert.IsFalse(isvalid);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string password = "SecurePassw0rd123";

            bool isvalid = Class1.Validatepassword(password);

            Assert.IsFalse(isvalid);
        }
    }
}
