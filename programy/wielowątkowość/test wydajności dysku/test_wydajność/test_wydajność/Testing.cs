using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test_wydajność
{
    public class Testing
    {
        private string folder;

        public Testing(string folder)
        {
            this.folder = folder;
        }
        public string chooseRandomFile()
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
            Stopwatch stopwatch = new Stopwatch();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                byte[] buffer = new byte[1024];

                stopwatch.Start();
                long bytesToWrite = (long)sizeToWrite * 1024 * 1024;
                long bytesWritten = 0;

                while (bytesWritten < bytesToWrite)
                {
                    int bytesToCopy = (int)Math.Min(1024, bytesToWrite - bytesWritten);
                    memoryStream.Write(buffer, 0, bytesToCopy);
                    bytesWritten += bytesToCopy;
                }

                stopwatch.Stop();
            }
            double writeSpeed = sizeToWrite / stopwatch.Elapsed.TotalSeconds;
            Console.WriteLine("WRITTEN " + sizeToWrite + " " + writeSpeed);
            return writeSpeed;
        }
    }
}
