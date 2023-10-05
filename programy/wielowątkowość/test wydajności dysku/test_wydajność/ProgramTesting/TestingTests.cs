using Microsoft.VisualStudio.TestTools.UnitTesting;
using test_wydajność;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_wydajność.Tests
{
    [TestClass()]
    public class TestingTests
    {
/*        [TestMethod()]
        public void TestingTest()
        {

        }*/

        [TestMethod()]
        public void chooseRandomFileTest()
        {
            Testing testing = new Testing("C:\\TST");
            Assert.IsTrue(File.Exists(testing.chooseRandomFile()));
        }

        [TestMethod()]
        public void readSpeedTest()
        {
            Testing testing = new Testing("C:\\TST");
            double b = testing.readSpeed();
            Assert.IsTrue(b > 0);
        }

        [TestMethod()]
        public void writeSpeedTest()
        {
            Testing testing = new Testing("C:\\TST");
            double a = testing.writeSpeed(100);
            Assert.IsTrue(a > 0);
        }
    }
}