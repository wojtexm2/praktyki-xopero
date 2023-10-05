using System.Diagnostics;
using test_wydajnoœæ;

namespace ProgramTesting
{
    [TestClass]
    public class MyTests
    {
        [TestMethod]
        public void TestMultithreadingAbility()
        {
            Stopwatch stopwatch = new Stopwatch();
            int threadNumber = 3;
            Thread[] threads = new Thread[threadNumber];
            for (int i = 0; i < threadNumber; i++)
            {
                threads[i] = new Thread(function =>
                {
                    Thread.Sleep(3000);
                });
                threads[i].Start();
            }
            stopwatch.Start();
            for (int i = 0; i < threadNumber; i++)
            {
                threads[i].Join();
            }
            stopwatch.Stop();
            if (stopwatch.Elapsed.TotalMilliseconds > 3500)
            {
                Assert.Fail("Multitasking is either unavailable or computer is too slow.");
            }

        }
    }
}