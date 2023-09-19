﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_1__Test_interface_
{
    internal class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "Mam " + numberOfScaryThings + " pająków"; }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Buu! Mam cię!");
        }
    }
}
