using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Zuduj_dom_
{
    internal class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
        public override string Description
        {
            get { return base.Description + " Widzisz tutaj " + decoration + "."; }
        }
    }
}
