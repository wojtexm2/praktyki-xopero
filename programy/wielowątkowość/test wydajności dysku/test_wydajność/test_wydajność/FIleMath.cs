using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_wydajność
{
    public static class FIleMath
    {
        public static double CalculateReadSpeed(double totalSpeedRead, double totalFilesRead)
        {
            return Math.Floor(totalSpeedRead / totalFilesRead);
        }
        public static double CalculateWriteSpeed(double totalSpeedWrite, double threadsWorkingOnWrite)
        {
            return Math.Floor(totalSpeedWrite / threadsWorkingOnWrite);
        }
    }
}
