using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Lista_kaczek_
{
    internal class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
        public int CompareTo(Duck duckToCompare)
        {
            if (this.Size > duckToCompare.Size) return 1;
            else if (this.Size < duckToCompare.Size) return -1;
            else return 0;
        }
        public override string ToString()
        {
            return Size.ToString() + "-centymetrowa kaczka " + Kind.ToString();
        }
    }
}
