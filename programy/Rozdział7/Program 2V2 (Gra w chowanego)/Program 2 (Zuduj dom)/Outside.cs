﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2__Zuduj_dom_
{
    internal class Outside : Location
    {
        private bool hot;
        public Outside(string name, bool hot) : base(name)
        {
            this.hot = hot;
        }
        public override string Description
        {
            get
            {
                string NewDescription = base.Description;
                if (hot) NewDescription += " Tutaj jest bardzo gorąco.";
                return NewDescription;
            }
        }
    }
}
