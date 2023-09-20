﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Zuduj_dom_
{
    internal class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }
        public string DoorDescription { get; private set;}
        public Location DoorLocation { get; set; }
        public override string Description
        {
            get
            {
                return base.Description + " Widzisz teraz " + DoorDescription + ".";
            }
        }
    }
}
