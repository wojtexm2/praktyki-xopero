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
    public class FIleMathTests
    {
        [TestMethod()]
        public void CalculateReadSpeedTest()
        {
            Assert.AreEqual(FIleMath.CalculateReadSpeed(10, 2), 5);
        }

        [TestMethod()]
        public void CalculateWriteSpeedTest()
        {
            Assert.AreEqual(FIleMath.CalculateReadSpeed(10, 2), 5);
        }
    }
}