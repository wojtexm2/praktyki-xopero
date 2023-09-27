﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekt_wyprawa
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location)
        {

        }
        public override string Name { get { return "Luk"; } }

        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 600, 1, random);
        }
    }
}

