using test_wydajnoœæ;

namespace ProgramTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFileChoosing()
        {
            Testing testing = new Testing("C:\\Windows");

            Assert.IsTrue(File.Exists(testing.chooseRandomFile()));
        }
        [TestMethod]
        public void TestForFileReadingAndWriting()
        {
            Testing testing = new Testing("C:\\Windows");
            double a = testing.writeSpeed(100);
            double b = testing.readSpeed();
            Assert.IsTrue(a > 0 && b > 0);
        }
    }
}