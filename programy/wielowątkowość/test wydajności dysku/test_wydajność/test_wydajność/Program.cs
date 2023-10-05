using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace test_wydajność
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path;
            double size;

            Thread[] ReadThreads;
            Thread[] WriteThreads;
            int threadCount;
            int threadsWorkingOnRead;
            int threadsWorkingOnWrite;
          

            double totalSpeedWrite = 0;
            int totalFilesRead = 0;
            double totalSpeedRead = 0;
            bool finishWriting = false;

            //Getting values from user
            path = UserPrompt.PromptForPath();
            threadCount = UserPrompt.PromptForThreads();
            size = UserPrompt.PromptForSize();

            //Setting thread roles
            threadsWorkingOnRead = threadCount / 2;
            threadsWorkingOnWrite = threadCount - threadsWorkingOnRead;
            Console.WriteLine("Read: " + threadsWorkingOnRead + " threads");
            Console.WriteLine("Write: " + threadsWorkingOnWrite + " threads");
            ReadThreads = new Thread[threadsWorkingOnRead];
            WriteThreads = new Thread[threadsWorkingOnWrite];
            double sizeToWritePerThread = size / threadsWorkingOnWrite;
            Console.WriteLine("WritePerThread: " + sizeToWritePerThread);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            //Ustawianie wątków
            //Wątki odczytu
            for (int i = 0; i < threadsWorkingOnRead; i++)
            {
                ReadThreads[i] = new Thread(function =>
                {
                    Testing testing = new Testing(path);
                    while (!finishWriting)
                    {
                        try
                        {
                            double rSpeed = testing.readSpeed();
                            totalSpeedRead += rSpeed;
                            totalFilesRead++;
                        }
                        catch (IOException e)
                        {
                            continue;
                        }
                    }
                });
                ReadThreads[i].Start();
            }
            //Wątki zapisu
            for (int i = 0; i < threadsWorkingOnWrite; i++)
            {
                WriteThreads[i] = new Thread(function =>
                {
                    Testing testing = new Testing(path);
                    totalSpeedWrite += testing.writeSpeed(sizeToWritePerThread);
                });
                WriteThreads[i].Start();
            }
            //Oczekiwanie na wątki
            for (int i = 0; i < threadsWorkingOnWrite; i++)
            {
                WriteThreads[i].Join();
            }
            finishWriting = true;
            for (int i = 0; i < threadsWorkingOnRead; i++)
            {
                ReadThreads[i].Join();
            }
            stopwatch.Stop();
            Console.WriteLine("=======================");
            Console.WriteLine("Time: *" + Math.Floor(stopwatch.Elapsed.TotalSeconds) + "s");
            Console.WriteLine("Read: *" + FIleMath.CalculateReadSpeed(totalSpeedRead, totalFilesRead) + " MB/s");
            Console.WriteLine("Write: *" + FIleMath.CalculateWriteSpeed(totalSpeedWrite, threadsWorkingOnWrite) + "MB/s");


        }
    }
}