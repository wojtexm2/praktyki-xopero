using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    internal class Greyhound
    {
        public int StartingPosition = 22;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            throw new NotImplementedException();
            //losowy bieg o 1 2 3 lub 4 punkty
            //aktualizacja położenia
            //return true if wygrana
        }
        public void TakeStartingPoistion()
        {
            //zerowanie punktu startowego
        }
    }
}
