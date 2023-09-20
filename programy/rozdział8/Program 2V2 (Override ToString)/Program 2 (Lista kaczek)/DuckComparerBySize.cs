using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Lista_kaczek_
{
    internal class DuckComparerBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size < y.Size) return -1;
            if (x.Size > y.Size) return 1;
            else return 0;
        }
    }
}
