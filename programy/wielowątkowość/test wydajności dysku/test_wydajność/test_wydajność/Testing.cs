using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test_wydajność
{
    internal class Testing
    {
        private string folder;

        public Testing(string folder)
        {
            this.folder = folder;
        }
        private string chooseRandomFile()
        {
            string path;
            Random random = new Random();
            string[] allFiles = Directory.GetFiles(folder);
            string file;
                
            file = allFiles[random.Next(allFiles.Length)];
            
            return file;
        }
        public double readSpeed()
        {
            Stopwatch stopwatch = new Stopwatch();
            string filePath = chooseRandomFile();
            stopwatch.Start();

            Console.WriteLine("READING " + filePath);
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                stopwatch.Start();

                while ((bytesRead = fileStream.Read(buffer, 0, 1024)) > 0) ;

                stopwatch.Stop();
            }
            long fileSize = new FileInfo(filePath).Length;
            double fileSizeMB = fileSize / (1024.0 * 1024.0);
            double readSpeed = fileSizeMB / stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine(filePath + " - " + readSpeed);

            return readSpeed;
        }
        public double writeSpeed(double sizeToWrite)
        {
            Thread.Sleep(2000);
            return 0d;
        }
    }
}
