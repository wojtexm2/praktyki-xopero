using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    internal class Greyhound
    {
        public int RacetrackLength = 530;
        public PictureBox MyPictureBox = null;
        public int StartingPosition = 20;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            MyPictureBox.Left += MyRandom.Next(1, 5);
            Location = MyPictureBox.Left;
            if (Location >= RacetrackLength)
            {
                return true;
            }
            return false;
            //return true if wygrana
        }
        public void TakeStartingPoistion()
        {
            MyPictureBox.Left = StartingPosition;
            Location = 0;
        }
    }
}
