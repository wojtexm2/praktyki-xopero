﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyprawa
{
    internal class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {

        }
        public override void Move(Random random)
        {
            if (HitPoints >= 1)
            {
                if (random.Next(1, 4) > 1)
                    location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (NearPlayer())
                    game.HitPlayer(4, random);
            }

        }
    }
}
