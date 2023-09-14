using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program1
{
    internal class Talker
    {
        public static int BlahBlahBlah(string thingToSay, int numberOfTImes)
        {
            string finalString = "";
            for (int count = 1; count <= numberOfTImes; count++)
            {
                finalString += thingToSay + "\n";
            }
            MessageBox.Show(finalString);
            return finalString.Length;
        }
    }
}
