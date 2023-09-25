using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2___projekt_dla_facetów__
{
    [Serializable]
    internal class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int ammount)
        {
            if (ammount <= Cash && ammount > 0)
            {
                Cash -= ammount;
                return ammount;
            }
            else
            {
                MessageBox.Show("Nie mam wystarczającej ilości pieniędzy, aby Ci dać " + ammount, Name + "powiedział...");
                return 0;
            }
        }
        public int RecieveCash(int ammount)
        {
            if (ammount > 0)
            {
                Cash += ammount;
                return ammount;
            }
            else
            {
                MessageBox.Show(ammount + " to nie jest ilość pieniędzy, jaką mogęwziąć", Name + " powiedział...");
                return 0;
            }
        }
    }
}
