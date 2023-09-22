﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Śniadanie_dla_drwali
{
    internal class Lumberjack
    {
        private string name;
        public string Name { get { return name; } }
        private Stack<Flapjack> meal;
        public Lumberjack (string name)
        {
            this.name = name;
            meal = new Stack<Flapjack> ();
        }
        public int FlapjackCount { get { return meal.Count; } }
        public void TakeFlapjacks(Flapjack food, int HowMany)
        {
            for (int i = 0; i < HowMany; i++)
            {
                meal.Push(food);
            }
        }
        public void EatFlapjacks()
        {
            Console.WriteLine(name + " je naleśniki");
            while (meal.Count > 0)
            {
                Console.WriteLine(name + " zjadł " + meal.Pop().ToString().ToLower() + " naleśnika");
            }
        }
    }
}
