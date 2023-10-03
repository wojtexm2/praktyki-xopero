using System.Diagnostics;
using System.Reflection;

namespace test_wydajność
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path;
            int threadCount;
            int size;
            Thread[] Threads;

            path = UserPrompt.PromptForPath();
            threadCount = UserPrompt.PromptForThreads();
            size = UserPrompt.PromptForSize();
            Threads = new Thread[threadCount];

            for (int i = 0; i < threadCount; i++)
            {
                Threads[i] = new Thread(fnct);
                Threads[i].Start();
            }
            for (int i = 0; i < threadCount; i++)
            {
                Threads[i].Join();
            }

            
        }
        public static void fnct()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I exist!");
                Thread.Sleep(1000);
            }
        }
    }
}